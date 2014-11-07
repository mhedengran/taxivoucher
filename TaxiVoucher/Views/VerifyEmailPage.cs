using System;
using Xamarin.Forms;

namespace TaxiVoucher
{
	public class VerifyEmailPage : ContentPage
	{
		public VerifyEmailPage()
		{
			Title = "Create user";

			Button loginButton = new Button {
				Text = "Login",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.EndAndExpand,
			};
			loginButton.Clicked += OnLoginClicked;

			StackLayout stacklayout = new StackLayout
			{
				Spacing = 10,
				VerticalOptions = LayoutOptions.FillAndExpand,

				Padding = new Thickness(20, 100, 20, 10),
				Children = 
				{
					new Label
					{
						Text = "A mail has been sent to your e-mail address, please verify it",
						VerticalOptions = LayoutOptions.Center,
						HorizontalOptions = LayoutOptions.CenterAndExpand,
					},
					loginButton,
				}
			};

			Content = stacklayout;
		}

		void OnLoginClicked(object sender, EventArgs e) {

			//figure out how to get this to work (nice to have)
//			Navigation.PopToRootAsync ();
			Navigation.PushAsync (new MenuPage ());
		}
	}
}

