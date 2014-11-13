using System;
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
				Keyboard = Keyboard.Text,
				Placeholder = "Bon nummer",
				VerticalOptions = LayoutOptions.Start
			};

			priceEntry = new Entry {
				Keyboard = Keyboard.Numeric,
				Placeholder = "Pris",
				VerticalOptions = LayoutOptions.Start
			};

			streetEntry = new Entry {
				Keyboard = Keyboard.Text,
				Placeholder = "Vej",
				VerticalOptions = LayoutOptions.End,
			};

			numberEntry = new Entry {
				Keyboard = Keyboard.Numeric,
				Placeholder = "Nr",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start
			};

			zipCodeEntry = new Entry {
				Keyboard = Keyboard.Numeric,
				Placeholder = "Postnummer",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};

			cityEntry = new Entry {
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
			Console.WriteLine ("finish trip");
			//get current location
			Geolocator locator = DependencyService.Get<IGeoLocator> ().GetLocator(); 
			Console.WriteLine ("available:" + locator.IsGeolocationAvailable);
			Console.WriteLine ("enabled:" + locator.IsGeolocationEnabled);
//			await locator;
			await locator.GetPositionAsync (timeout: 100000).ContinueWith (t => {
				Console.WriteLine ("Position Status: {0}", t.Status.ToString()); //if != RanToCompletion do something
				Console.WriteLine ("Position Latitude: {0}", t.Result.Latitude);
				Console.WriteLine ("Position Longitude: {0}", t.Result.Longitude);
				var addressTask = new CommunicationHelper().StartBooking(t.Result.Latitude, t.Result.Longitude, driver.Token);
				string address = addressTask.Result;
				Console.WriteLine(address);
			}, TaskScheduler.FromCurrentSynchronizationContext());
//			Navigation.PushAsync (new VoucherReceiptPage ());
		}
	}
}

