using System;
using Xamarin.Forms;

namespace TaxiPay
{
	public class VerifyEmailPage : ContentPage
	{
		public VerifyEmailPage()
		{
			Title = "Opret bruger";

			Button loginButton = new Button {
				Text = "Gå til Login",
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
						Text = "En email er blevet sendt til din e-mailadresse, vær venlig at verificere den",
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
			Navigation.PopToRootAsync ();
//			Navigation.PushAsync (new MenuPage ());
		}
	}
}

