using System;
using Xamarin.Forms;

namespace TaxiPay
{
	public class MenuPage : ContentPage
	{
		Driver driver;
		public MenuPage (Driver drvr)
		{
			driver = drvr;

			Title = "Menu";

			Button redeemButton = new Button {
				Text = "Indløs bon",
				HorizontalOptions = LayoutOptions.Center,
			};
			redeemButton.Clicked += OnRedeemClicked;

			Button logButton = new Button {
				Text = "Log",
				HorizontalOptions = LayoutOptions.Center,
			};
			logButton.Clicked += OnLogClicked;

			Button settingsButton = new Button {
				Text = "Indstillinger",
				HorizontalOptions = LayoutOptions.Center,
			};
			settingsButton.Clicked += OnSettingsClicked;

			StackLayout stacklayout = new StackLayout
			{
				Spacing = 50,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(20, 50, 20, 100),
				Children = 
				{
					redeemButton,
					logButton,
					settingsButton,

					new Label {
						Text = "Du har ikke indtastet nogen bankoplysninger endnu, blah blah blah",
						VerticalOptions = LayoutOptions.EndAndExpand,
						HorizontalOptions = LayoutOptions.CenterAndExpand,
					},
				}
			};

			Content = stacklayout;
		}

		void OnRedeemClicked(object sender, EventArgs e) {
			Console.WriteLine ("Redeem");
			Navigation.PushAsync (new RedeemVoucherPage (driver));
		}

		void OnLogClicked(object sender, EventArgs e) 
		{
			Navigation.PushAsync(new TotalLogPage (driver));
		}

		void OnSettingsClicked(object sender, EventArgs e) 
		{
			Navigation.PushAsync (new SettingsPage (driver));
		}
	}
}

