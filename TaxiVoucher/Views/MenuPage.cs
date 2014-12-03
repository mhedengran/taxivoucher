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

			MenuButton redeemButton = new MenuButton {
				LabelText = "Indløs digital taxabon",
				Icon = IconStrings.cabIcon,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				HeightRequest = 50

			};
			redeemButton.Clicked += OnRedeemClicked;

			MenuButton logButton = new MenuButton {
				LabelText = "Log",
				Icon = IconStrings.listIcon,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				HeightRequest = 50
			};
			logButton.Clicked += OnLogClicked;

			MenuButton settingsButton = new MenuButton {
				LabelText = "Indstillinger",
				Icon = IconStrings.cogsIcon,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				HeightRequest = 50
			};
			settingsButton.Clicked += OnSettingsClicked;

			StackLayout stacklayout = new StackLayout
			{
				Spacing = 15,
				BackgroundColor = Color.FromHex(Colors.backgroundColor),
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(30, 50, 30, 100),
				Children = 
				{
					redeemButton,
					logButton,
					settingsButton,

					new Label {
						Text = "Du har ikke indtastet nogen bankoplysninger endnu, blah blah blah",
						VerticalOptions = LayoutOptions.EndAndExpand,
						HorizontalOptions = LayoutOptions.CenterAndExpand,
						TextColor = Color.FromHex(Colors.textColor)
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

