using System;
using Xamarin.Forms;
using Xamarin.Geolocation;
using System.Threading.Tasks;

namespace TaxiPay
{
	public class RedeemVoucherPage : ContentPage
	{
		Driver driver;

		TextEntry priceEntry;
		TextEntry voucherCodeEntry;
		TextEntry streetEntry;
		TextEntry numberEntry;
		TextEntry zipCodeEntry;
		TextEntry cityEntry;

		public RedeemVoucherPage (Driver drvr)
		{
			driver = drvr;

			Title = "Indløs";
			BackgroundColor = Color.FromHex (Colors.backgroundColor);

			NormalButton finishTripButton = new NormalButton {
				Text = "Afslut tur",
				ArrowPositionRight = true,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.EndAndExpand,
				HeightRequest = 40,

			};
			finishTripButton.Clicked += OnFinishTripClicked;

			EntryLayout voucherLayout = new EntryLayout ();
			StackLayout voucherField = voucherLayout.GetTextEntryLayout ("Bonnummer", "", Keyboard.Text, false, LayoutOptions.FillAndExpand);
			voucherCodeEntry = voucherLayout.TextEntry;

			EntryLayout priceLayout = new EntryLayout ();
			StackLayout priceField = priceLayout.GetTextEntryLayout ("pris", "", Keyboard.Numeric, false, LayoutOptions.FillAndExpand);
			priceEntry = priceLayout.TextEntry;

			EntryLayout streetLayout = new EntryLayout ();
			StackLayout streetField = streetLayout.GetTextEntryLayout ("Vejnavn", "", Keyboard.Text, false, LayoutOptions.FillAndExpand);
			streetEntry = streetLayout.TextEntry;

			EntryLayout numberLayout = new EntryLayout ();
			StackLayout numberField = numberLayout.GetTextEntryLayout ("Nr.", "", Keyboard.Text, false, null);
			numberEntry = numberLayout.TextEntry;
			numberEntry.WidthRequest = 80;

			EntryLayout zipCodeLayout = new EntryLayout ();
			StackLayout zipCodeField = zipCodeLayout.GetTextEntryLayout ("Postnr.", "", Keyboard.Numeric, false, null);
			zipCodeEntry = zipCodeLayout.TextEntry;
			zipCodeEntry.WidthRequest = 80;

			EntryLayout cityLayout = new EntryLayout ();
			StackLayout cityField = cityLayout.GetTextEntryLayout ("By", "", Keyboard.Text, false, LayoutOptions.FillAndExpand);
			cityEntry = cityLayout.TextEntry;

			StackLayout horizontalStacklayout = new StackLayout
			{
				Spacing = 10,
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children =
				{
					streetField,
					numberField
				}
			};

			StackLayout horizontalStacklayout2 = new StackLayout
			{
				Spacing = 10,
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children =
				{
					zipCodeField,
					cityField
				}
				};

			StackLayout stacklayout = new StackLayout
			{
				Spacing = 10,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(30, 30, 30, 30),
				Children = 
				{
					voucherField,
					priceField,

					new Label
					{
						Text = "Start adressen",
						TextColor = Color.FromHex(Colors.textColor),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.EndAndExpand
					},
					horizontalStacklayout,
					horizontalStacklayout2,

					finishTripButton
				}
			};
			ScrollView view = new ScrollView {
				Content = stacklayout
			};
			Content = view;

			UpdateViewWithCurrentAddress ();
		}

		async void UpdateViewWithCurrentAddress () {
				Geolocator locator = DependencyService.Get<IGeoLocator> ().GetLocator ();
				Console.WriteLine ("available:" + locator.IsGeolocationAvailable);
				Console.WriteLine ("enabled:" + locator.IsGeolocationEnabled);
				await locator.GetPositionAsync (timeout: 5000).ContinueWith (t => {
				Console.WriteLine(t.Status.ToString());
					if (t.Status.ToString ().Equals ("RanToCompletion")) {
						Console.WriteLine ("Position Status: {0}", t.Status.ToString ());
						Console.WriteLine ("Position Latitude: {0}", t.Result.Latitude);
						Console.WriteLine ("Position Longitude: {0}", t.Result.Longitude);
					    var getAddressTask = new CommunicationHelper ().GetAddress(t.Result.Latitude, t.Result.Longitude, driver.Token);
						AddressLocation address = getAddressTask.Result;
						streetEntry.Text = address.StreetName;
						numberEntry.Text = address.HouseNumber;
						zipCodeEntry.Text = address.ZipCode;
						cityEntry.Text = address.City;
					}
				}, TaskScheduler.FromCurrentSynchronizationContext ());
		}

		async void OnFinishTripClicked(object sender, EventArgs e) 
		{
			await Navigation.PushAsync (new VoucherReceiptPage (500, 700));
//			double temp = 0;
//			if (voucherCodeEntry.Text.Equals ("") || priceEntry.Text.Equals ("") || !double.TryParse (priceEntry.Text, out temp)) {
//				await DisplayAlert ("Forkert indtastning", "Indtast korrekt Bon-data i begge felter", "OK");
//			} else {
//				//pay flow
//				CommunicationHelper comm = new CommunicationHelper ();
//				//1. go online
//				var goOnlineTask = comm.PutDriverOnline (driver);
//				Console.WriteLine (goOnlineTask.Result);
//				//2. update position
//				Location loc = new Location ();
//				string bookingId = "";
//				if (streetEntry.Text.Equals ("") || numberEntry.Text.Equals ("") || cityEntry.Text.Equals ("") || zipCodeEntry.Text.Equals ("")) {
//					await DisplayAlert ("Forkert indtastning", "Indtast en korrekt adresse", "OK");
//				} else {
//					var getLocationTask = comm.GetLocation (streetEntry.Text, numberEntry.Text, cityEntry.Text, zipCodeEntry.Text, driver.Token);
//					loc.Latitude = getLocationTask.Result[0].Lat;
//					loc.Longtitude = getLocationTask.Result[0].Lng;
//					var updatePositionTask = comm.UpdatePostion (loc.Latitude, loc.Longtitude, driver);
//					bookingId = updatePositionTask.Result;
//				}
//				//3. create booking
//				if (bookingId.Equals ("")) {
//					var bookingIdTask = comm.StartBooking (loc.Latitude, loc.Longtitude, driver.Token);
//					bookingId = bookingIdTask.Result;
//				}
//				//4. update position
//				Geolocator locator = DependencyService.Get<IGeoLocator> ().GetLocator ();
//				await locator.GetPositionAsync (timeout: 10000).ContinueWith (t => {
//					if (t.Status.ToString ().Equals ("RanToCompletion")) {
//						Console.WriteLine ("Position Status: {0}", t.Status.ToString ()); //if != RanToCompletion do something
//						Console.WriteLine ("Position Latitude: {0}", t.Result.Latitude);
//						Console.WriteLine ("Position Longitude: {0}", t.Result.Longitude);
//						loc.Latitude = t.Result.Latitude;
//						loc.Longtitude = t.Result.Longitude;
//						var updatePositionTask = comm.UpdatePostion (t.Result.Latitude, t.Result.Longitude, driver);
//						Console.WriteLine (updatePositionTask.Result);
//					}
//				}, TaskScheduler.FromCurrentSynchronizationContext ());
//				//5. add voucher
//				var applyVoucherTask = comm.ApplyVoucher (driver, bookingId, voucherCodeEntry.Text);
//				string voucherResult = applyVoucherTask.Result;
//				if (voucherResult.Contains("VOUCHER_NOT_FOUND")) {
//					Console.WriteLine (voucherResult);
//					await DisplayAlert ("Ugyldigt!", "Bon-nummer er ikke gyldigt", "OK");
//				} else {
//					//6. finish booking
//					var endBookingTask = comm.EndBooking (driver, bookingId, Convert.ToDouble (priceEntry.Text));
//					var endBookingResult = endBookingTask.Result;
//					//7. finish payments
//					var finishPaymentsTask = comm.FinishPayments (driver, bookingId);
//					string finishPaymentsResult = finishPaymentsTask.Result;
//					//8. go offline
//					var goOfflineTask = comm.PutDriverOffline (driver);
//					Console.WriteLine (goOfflineTask.Result);
//					if (endBookingResult.SystemMessage != null || finishPaymentsResult.Equals ("error")) {
//						await DisplayAlert ("Fejl!", "Et eller andet gik galt, undersøg netforbindelsen, og prøv igen", "OK");
//					} else {
//						await Navigation.PushAsync (new VoucherReceiptPage (endBookingResult.Payment.PriceParts.Voucher, endBookingResult.Payment.PriceParts.Base));
//					}
//
//				}
//				
//			}
		}
	}
}

