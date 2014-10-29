using System;
using Xamarin.Forms;

namespace TaxiVoucher
{
	public class LoginPage : ContentPage
	{
		Entry emailEntry;
		Entry passwordEntry;
		Label forgotPasswordLabel;

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

			emailEntry = new Entry {
				Keyboard = Keyboard.Email,
				Placeholder = "E-mail",
				VerticalOptions = LayoutOptions.Center,
			};

			passwordEntry = new Entry {
				Keyboard = Keyboard.Text,
				Placeholder = "Password",
				IsPassword = true,
				VerticalOptions = LayoutOptions.Center
			};

			forgotPasswordLabel = new Label {
				Text = "",
				HorizontalOptions = LayoutOptions.Center
			};

			StackLayout stacklayout = new StackLayout
			{
				Spacing = 10,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(20, 100, 20, 10),
				Children = 
				{
					emailEntry,
					passwordEntry,
					loginButton,
					forgotPasswordButton,
					forgotPasswordLabel,
					createUserButton,

				}
			};

			Content = stacklayout;
		}

		void OnLoginClicked(object sender, EventArgs e) {
			Navigation.PushAsync (new MenuPage ());
		}

		void OnCreateUserClicked(object sender, EventArgs e) 
		{
			Navigation.PushAsync(new CreateUserPage());
		}

		void OnForgotPasswordClicked(object sender, EventArgs e) 
		{
			emailEntry.Unfocus();
			passwordEntry.Unfocus();
			Console.WriteLine ("Forgot password");
			if (emailEntry.Text != null) {
				if (emailEntry.Text.Contains ("@") && emailEntry.Text.Contains (".")) {
					//send email
					forgotPasswordLabel.Text = "Email sent";
					return;
				}
			} 
			forgotPasswordLabel.Text = "Enter a valid email";
		}
	}
}

