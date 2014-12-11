using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace TaxiPay
{
	public class LoginPage : ContentPage
	{
		TextEntry emailEntry;
		TextEntry passwordEntry;
		Label forgotPasswordLabel;

		StackLayout stacklayout;

		public LoginPage ()
		{
			Title = "Login";
			BackgroundColor = Color.FromHex (Colors.backgroundColor);

			NormalButton loginButton = new NormalButton {
				Text = "Login",
				ArrowPositionRight = true,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HeightRequest = 40,
			};
			loginButton.Clicked += OnLoginClicked;

			MenuButton forgotPasswordButton = new MenuButton {
				LabelText = "Glemt password",
				HorizontalOptions = LayoutOptions.FillAndExpand,
				HeightRequest = Device.OnPlatform(30,40,30),
			};
			forgotPasswordButton.Clicked += OnForgotPasswordClicked;

			NormalButton createUserButton = new NormalButton {
				Text = "Opret bruger",
				ArrowPositionRight = true,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.EndAndExpand,
				HeightRequest = 40,
			};
			createUserButton.Clicked += OnCreateUserClicked;

			EntryLayout emailLayout = new EntryLayout ();
			StackLayout emailField = emailLayout.GetLayoutWithIcon ("E-mail", "", Keyboard.Email, IconStrings.atIcon, false);
			emailEntry = emailLayout.TextEntry;

			EntryLayout passwordLayout = new EntryLayout ();
			StackLayout passwordField = passwordLayout.GetLayoutWithIcon ("Password", "", Keyboard.Create (0x00), IconStrings.lockIcon, true);
			passwordEntry = passwordLayout.TextEntry;

			stacklayout = new StackLayout
			{
				Spacing = 10,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(30, 50, 30, 30),
				Children = 
				{
					emailField,
					passwordField,
					forgotPasswordButton,
					loginButton,
					createUserButton,

				}
			};
			ScrollView view = new ScrollView {
				Content = stacklayout
			};
			Content = view;
		}

		async void OnLoginClicked(object sender, EventArgs e) {
//			var activity = new ActivityIndicator {
//				HorizontalOptions = LayoutOptions.CenterAndExpand,
//				VerticalOptions = LayoutOptions.CenterAndExpand,
//				Color = Color.White,
//				HeightRequest = 60,
//				WidthRequest = 60,
//			};
//			this.Content = new StackLayout {
//				HorizontalOptions = LayoutOptions.FillAndExpand,
//				VerticalOptions = LayoutOptions.FillAndExpand,
//				BackgroundColor = Color.Black.MultiplyAlpha (0.2),
//				Children = { activity }
//			};
//			activity.IsRunning = true;

			CommunicationHelper helper = new CommunicationHelper ();
			Task<JSONResponse> driverTask = helper.Login (emailEntry.Text, passwordEntry.Text);
			JSONResponse response = driverTask.Result;
//			activity.IsRunning = false;
//			this.Content = stacklayout;
			if (response.SystemMessage != null) {
//				await DisplayAlert ("Error logging in", response.SystemMessage, "OK");
				await DisplayAlert ("Fejl", "Forkert email eller kodeord", "OK");
			} else {
				Console.WriteLine (response.Driver.ToString());
				Driver driver = response.Driver;
				driver.Token = response.Token;
				//save email as default
				this.Title = "Logout";
				await Navigation.PushAsync (new MenuPage (driver));
			}
		}

		void OnCreateUserClicked(object sender, EventArgs e) 
		{
			Navigation.PushAsync(new CreateUserPage());
		}

		async void OnForgotPasswordClicked(object sender, EventArgs e) 
		{
			emailEntry.Unfocus();
			passwordEntry.Unfocus();
			Console.WriteLine ("Forgot password");
			if (emailEntry.Text != null) {
				if (emailEntry.Text.Contains ("@") && emailEntry.Text.Contains (".")) {
					CommunicationHelper comm = new CommunicationHelper ();
					Task<string> resetPwTask = comm.ResetPassword (emailEntry.Text);
					string response = resetPwTask.Result;
					if (response.Contains ("EMAIL_NOT_FOUND")) {
						await DisplayAlert ("Fejl", "Forkert email", "OK");
					} else {
						await DisplayAlert ("Godkendt", "Email med oplysninger omkring nulstilling af password er sendt", "OK");
					}
					return;
				}
			} 
			await DisplayAlert ("Fejl", "Skriv en rigtig email", "OK");
		}
	}
}

