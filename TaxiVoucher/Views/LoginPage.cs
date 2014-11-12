using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace TaxiPay
{
	public class LoginPage : ContentPage
	{
		Entry emailEntry;
		Entry passwordEntry;
		Label forgotPasswordLabel;

		public LoginPage ()
		{
			Title = "Login";
			//needs to be set in constructor
//			NavigationPage.SetBackButtonTitle (this, "Logout");

			Button loginButton = new Button {
				Text = "Login",
				HorizontalOptions = LayoutOptions.Center
			};
			loginButton.Clicked += OnLoginClicked;

			Button forgotPasswordButton = new Button {
				Text = "Glemt password",
				HorizontalOptions = LayoutOptions.Center
			};
			forgotPasswordButton.Clicked += OnForgotPasswordClicked;

			Button createUserButton = new Button {
				Text = "Opret bruger",
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

		async void OnLoginClicked(object sender, EventArgs e) {
			CommunicationHelper helper = new CommunicationHelper ();
			Task<JSONResponse> driverTask = helper.login (emailEntry.Text, passwordEntry.Text);
			JSONResponse response = driverTask.Result;
			if (response.SystemMessage != null) {
				await DisplayAlert ("Error logging in", response.SystemMessage, "OK");
			} else {
				Console.WriteLine (response.Driver.ToString());
				Driver driver = response.Driver;
				driver.Token = response.Token;
				Navigation.PushAsync (new MenuPage (driver));
			}
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
					forgotPasswordLabel.Text = "Email sendt";
					return;
				}
			} 
			forgotPasswordLabel.Text = "Skriv en rigtig email";
		}
	}
}

