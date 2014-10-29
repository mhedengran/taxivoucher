using System;
using Xamarin.Forms;

namespace TaxiVoucher
{
	public class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			Title = "Menu";

			Button redeemButton = new Button {
				Text = "Redeem voucher",
				HorizontalOptions = LayoutOptions.Center,
			};
			redeemButton.Clicked += OnRedeemClicked;

			Button logButton = new Button {
				Text = "Log",
				HorizontalOptions = LayoutOptions.Center,
			};
			logButton.Clicked += OnLogClicked;

			Button settingsButton = new Button {
				Text = "Settings",
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
						Text = "You haven't entered any bank information yet, blah blah blah",
						VerticalOptions = LayoutOptions.EndAndExpand,
						HorizontalOptions = LayoutOptions.CenterAndExpand,
					},
				}
			};

			Content = stacklayout;
		}

		void OnRedeemClicked(object sender, EventArgs e) {
			Console.WriteLine ("Redeem");
		}

		void OnSettingsClicked(object sender, EventArgs e) 
		{
			Console.WriteLine ("Log");
		}

		void OnLogClicked(object sender, EventArgs e) 
		{
			Console.WriteLine ("Settings");
		}
	}
}

