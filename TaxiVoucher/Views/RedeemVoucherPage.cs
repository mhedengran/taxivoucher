﻿using System;
using Xamarin.Forms;
using Xamarin.Geolocation;
using System.Threading.Tasks;

namespace TaxiPay
{
	public class RedeemVoucherPage : ContentPage
	{
		Driver driver;

		Entry priceEntry;
		Entry voucherCodeEntry;
		Entry streetEntry;
		Entry numberEntry;
		Entry zipCodeEntry;
		Entry cityEntry;

		public RedeemVoucherPage (Driver drvr)
		{
			driver = drvr;

			Title = "Indløs";



			Button finishTripButton = new Button {
				Text = "Afslut tur",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.End,

			};
			finishTripButton.Clicked += OnFinishTripClicked;
			Device.OnPlatform(
				Default: () => finishTripButton.HeightRequest = 50
			);

			voucherCodeEntry = new Entry {
				Text = "",
				Keyboard = Keyboard.Text,
				Placeholder = "Bon nummer",
				VerticalOptions = LayoutOptions.Start
			};

			priceEntry = new Entry {
				Text = "",
				Keyboard = Keyboard.Numeric,
				Placeholder = "Pris",
				VerticalOptions = LayoutOptions.Start
			};

			streetEntry = new Entry {
				Text = "",
				Keyboard = Keyboard.Text,
				Placeholder = "Vej",
				VerticalOptions = LayoutOptions.End,
			};

			numberEntry = new Entry {
				Text = "",
				Keyboard = Keyboard.Numeric,
				Placeholder = "Nr",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start
			};

			zipCodeEntry = new Entry {
				Text = "",
				Keyboard = Keyboard.Numeric,
				Placeholder = "Postnummer",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};

			cityEntry = new Entry {
				Text = "",
				Keyboard = Keyboard.Text,
				Placeholder = "By",
				VerticalOptions = LayoutOptions.End,
			};

			StackLayout horizontalStacklayout = new StackLayout
			{
				Spacing = 10,
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children =
				{
					numberEntry,
					zipCodeEntry
				}
			};

			StackLayout innerStacklayout = new StackLayout
			{
				Spacing = 10,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(20, 100, 20, 10),
				Children = 
				{
					voucherCodeEntry,
					priceEntry,

					new Label
					{
						Text = "Start adresse",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.EndAndExpand
					},
					streetEntry,
					horizontalStacklayout,
					cityEntry
				}
			};

			StackLayout outerStacklayout = new StackLayout {
				Spacing = 10,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = 
				{
					innerStacklayout,
					finishTripButton
				}
			};
			Content = outerStacklayout;
		}

		async void OnFinishTripClicked(object sender, EventArgs e) 
		{
			double temp = 0;
			if (voucherCodeEntry.Text.Equals ("") || priceEntry.Text.Equals ("") || !double.TryParse (priceEntry.Text, out temp)) {
				await DisplayAlert ("Forkert indtastning", "Indtast korrekt data i begge felter", "OK");
			} else {
				//pay flow
				CommunicationHelper comm = new CommunicationHelper ();
				//1. go online
				var goOnlineTask = comm.PutDriverOnline (driver);
				Console.WriteLine (goOnlineTask.Result);
				//2. update position
				//use reverse geocoding
				string bookingId = "";
				Location loc = new Location ();
				Geolocator locator = DependencyService.Get<IGeoLocator> ().GetLocator ();
				Console.WriteLine ("available:" + locator.IsGeolocationAvailable);
				Console.WriteLine ("enabled:" + locator.IsGeolocationEnabled);
				await locator.GetPositionAsync (timeout: 10000).ContinueWith (t => {
					if (t.Status.ToString ().Equals ("RanToCompletion")) {
						Console.WriteLine ("Position Status: {0}", t.Status.ToString ()); //if != RanToCompletion do something
						Console.WriteLine ("Position Latitude: {0}", t.Result.Latitude);
						Console.WriteLine ("Position Longitude: {0}", t.Result.Longitude);
						loc.Latitude = t.Result.Latitude;
						loc.Longtitude = t.Result.Longitude;
						var updatePositionTask = comm.UpdatePostion (t.Result.Latitude, t.Result.Longitude, driver);
						bookingId = updatePositionTask.Result;
						Console.WriteLine (bookingId);
					}
				}, TaskScheduler.FromCurrentSynchronizationContext ());
				//3. create booking
				if (bookingId.Equals ("")) {
					var bookingIdTask = comm.StartBooking (loc.Latitude, loc.Longtitude, driver.Token);
					bookingId = bookingIdTask.Result;
					//4. update position
					await locator.GetPositionAsync (timeout: 10000).ContinueWith (t => {
						if (t.Status.ToString ().Equals ("RanToCompletion")) {
							Console.WriteLine ("Position Status: {0}", t.Status.ToString ()); //if != RanToCompletion do something
							Console.WriteLine ("Position Latitude: {0}", t.Result.Latitude);
							Console.WriteLine ("Position Longitude: {0}", t.Result.Longitude);
							loc.Latitude = t.Result.Latitude;
							loc.Longtitude = t.Result.Longitude;
							var updatePositionTask = comm.UpdatePostion (t.Result.Latitude, t.Result.Longitude, driver);
							Console.WriteLine (updatePositionTask.Result);
						}
					}, TaskScheduler.FromCurrentSynchronizationContext ());
				}
				//5. add voucher
				var applyVoucherTask = comm.ApplyVoucher (driver, bookingId, voucherCodeEntry.Text);
				string voucherResult = applyVoucherTask.Result;
				if (voucherResult.Contains("VOUCHER_NOT_FOUND")) {
					Console.WriteLine (voucherResult);
					await DisplayAlert ("Ugyldigt!", "Bon-nummer er ikke gyldigt", "OK");
				} else {
					//6. finish booking
					var endBookingTask = comm.EndBooking (driver, bookingId, Convert.ToDouble (priceEntry.Text));
					var endBookingResult = endBookingTask.Result;
					//7. finish payments
					var finishPaymentsTask = comm.FinishPayments (driver, bookingId);
					string finishPaymentsResult = finishPaymentsTask.Result;
					//8. go offline
					var goOfflineTask = comm.PutDriverOffline (driver);
					Console.WriteLine (goOfflineTask.Result);
					if (endBookingResult.SystemMessage != null || finishPaymentsResult.Equals ("error")) {
						await DisplayAlert ("Fejl!", "Et eller andet gik galt, undersøg netforbindelsen, og prøv igen", "OK");
					} else {
						Navigation.PushAsync (new VoucherReceiptPage (endBookingResult.Payment.Receipt.Vouchers[0].Value, endBookingResult.Payment.Receipt.Price));
					}

				}
				
			}
		}
	}
}

