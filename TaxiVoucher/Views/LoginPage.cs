using System;
using Xamarin.Forms;

namespace TaxiVoucher
{
	public class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			Title = "Login";

			Button loginButton = new Button {
				Text = "Login",
				HorizontalOptions = LayoutOptions.Center
			};
			loginButton.Clicked += OnLoginClicked;

			Button forgotPasswordButton = new Button {
				Text = "Forgot password",
				HorizontalOptions = LayoutOptions.Center
			};
			forgotPasswordButton.Clicked += OnForgotPasswordClicked;

			Button createUserButton = new Button {
				Text = "Create user",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.EndAndExpand
			};
			createUserButton.Clicked += OnCreateUserClicked;

			StackLayout stacklayout = new StackLayout
			{
				Spacing = 10,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(20, 100, 20, 10),
				Children = 
				{
					new Entry
					{
						Keyboard = Keyboard.Email,
						Placeholder = "E-mail",
						VerticalOptions = LayoutOptions.Center,
					},

					new Entry
					{
						Keyboard = Keyboard.Text,
						Placeholder = "Password",
						IsPassword = true,
						VerticalOptions = LayoutOptions.Center
					},

					loginButton,
					forgotPasswordButton,
					createUserButton,

				}
			};

			Content = stacklayout;
		}

		void OnLoginClicked(object sender, EventArgs e) {
			Console.WriteLine ("Login");
		}

		void OnCreateUserClicked(object sender, EventArgs e) 
		{
			Navigation.PushAsync(new CreateUserPage());
		}

		void OnForgotPasswordClicked(object sender, EventArgs e) 
		{
			Console.WriteLine ("Forgot password");
		}
	}
}

