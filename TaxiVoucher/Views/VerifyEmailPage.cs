using System;
using Xamarin.Forms;

namespace TaxiPay
{
	public class VerifyEmailPage : ContentPage
	{
		public VerifyEmailPage()
		{
			Title = "Opret bruger";
			BackgroundColor = Color.FromHex (Colors.backgroundColor);

			NormalButton loginButton = new NormalButton {
				Text = "Tilbage til Login",
				ArrowPositionRight = false,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.EndAndExpand,
				HeightRequest = 40
			};
			loginButton.Clicked += OnLoginClicked;

			StackLayout stacklayout = new StackLayout
			{
				Spacing = 10,
				VerticalOptions = LayoutOptions.FillAndExpand,

				Padding = new Thickness(30, 100, 30, 30),
				Children = 
				{
					new Label
					{
						Text = "En email er blevet sendt til din e-mailadresse, vær venlig at verificere den",
						TextColor = Color.FromHex(Colors.textColor),
						VerticalOptions = LayoutOptions.CenterAndExpand,
						HorizontalOptions = LayoutOptions.CenterAndExpand,
					},
					loginButton,
				}
			};

			Content = stacklayout;
		}

		void OnLoginClicked(object sender, EventArgs e) {

			//figure out how to get this to work (nice to have)
			Navigation.PopToRootAsync ();
//			Navigation.PushAsync (new MenuPage ());
		}
	}
}

