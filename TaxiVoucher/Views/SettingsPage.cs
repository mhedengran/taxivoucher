using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace TaxiPay
{
	public class SettingsPage : ContentPage
	{
		Driver driver;

		Entry emailEntry;
		Entry password1Entry;
		Entry password2Entry;
		Entry swiftEntry;
		Entry ibanEntry;

		bool invalidEmail;

		public SettingsPage (Driver drvr)
		{
			driver = drvr;

			Title = "Indstillinger";

			emailEntry = new Entry {
				Text = driver.Email,
				Keyboard = Keyboard.Email,
				VerticalOptions = LayoutOptions.Start,
			};

			password1Entry = new Entry {
				Text = "",
				Keyboard = Keyboard.Create (0x00),
				Placeholder = "Skriv password",
				IsPassword = true,
				VerticalOptions = LayoutOptions.Start
			};

			password2Entry = new Entry {
				Text = "",
				Keyboard = Keyboard.Create (0x00),
				Placeholder = "Skriv password igen",
				IsPassword = true,
				VerticalOptions = LayoutOptions.Start
			};

			swiftEntry = new Entry {
				Text = "",
				Keyboard = Keyboard.Numeric,
				Placeholder = "Swift/BIC",
				VerticalOptions = LayoutOptions.EndAndExpand,
			};

			if (driver.BankAccount.Swift.Length > 0) {
				swiftEntry.Text = driver.BankAccount.Swift;
			}

			ibanEntry = new Entry {
				Text = "",
				Keyboard = Keyboard.Numeric,
				Placeholder = "IBAN",
				VerticalOptions = LayoutOptions.End,
			};

			if (driver.BankAccount.Iban.Length > 0) {
				ibanEntry.Text = driver.BankAccount.Iban;
			}

			//init switch
			Switch loginSwitch = new Switch
			{
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.Center
			};
			loginSwitch.Toggled += LoginSwitchToggled;

			Button saveButton = new Button {
				Text = "Gem",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.EndAndExpand
			};
			saveButton.Clicked += OnSaveClicked;

			StackLayout stacklayout = new StackLayout {
				Spacing = 10,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness (20, 20, 20, 10),
				Children = {

					new Label {
						Text = driver.ExternalReference,
						VerticalOptions = LayoutOptions.Center,
						HorizontalOptions = LayoutOptions.Start
					},

					emailEntry,
					password1Entry,
					password2Entry,
							
					new StackLayout
					{
						Spacing = 10,
						Orientation = StackOrientation.Horizontal,
						HorizontalOptions = LayoutOptions.FillAndExpand,
						Children = 
						{
							new Label
							{
								Text = "Login automatisk",
								HorizontalOptions = LayoutOptions.StartAndExpand,
								VerticalOptions = LayoutOptions.Center
							},
							loginSwitch,

						}
					},

					swiftEntry,
					ibanEntry,

					saveButton,
				}
			};
			Content = stacklayout;
		}

		void LoginSwitchToggled(object sender, ToggledEventArgs e) {
			if (e.Value) {
				Console.WriteLine ("Switch on");
			} else {
				Console.WriteLine ("Switch off");
			}	
		}

		async void OnSaveClicked(object sender, EventArgs e) 
		{
			//save data
			if (!driver.Email.Equals (emailEntry.Text) ||
			    (password1Entry.Text.Equals (password2Entry.Text) && password1Entry.Text.Length > 0) ||
				!driver.BankAccount.Swift.Equals (swiftEntry.Text) ||
				!driver.BankAccount.Iban.Equals (ibanEntry.Text)) {
				if (IsValidEmail (emailEntry.Text)) {
					if (!password1Entry.Text.Equals (password2Entry.Text)) {
						await DisplayAlert ("Fejlindtastning", "De to indtastede kodeord, matcher ikke", "OK");
					} else {
						if (password1Entry.Text.Length < 1) {
							password2Entry.Text = "";
						}
						var newDriver = new { email = emailEntry.Text,
							password = password2Entry.Text,
							bankAccount = new { swift = swiftEntry.Text, 
								iban = ibanEntry.Text, 
								accountHolderName = driver.FirstName + " " + driver.LastName }};

						CommunicationHelper comm = new CommunicationHelper ();
						var updateDriverTask = comm.UpdateDriver (newDriver, driver.Id, driver.Token);
						Driver tempDriver = updateDriverTask.Result;
						if (tempDriver.Id.Length < 1) {
							await DisplayAlert ("Ups", "Noget gik galt, tjek signalet og prøv igen", "OK");
						} else {
							driver.BankAccount = tempDriver.BankAccount;
							driver.BankAccount.AccountHolderName = driver.FirstName + " " + driver.LastName;
							driver.Email = tempDriver.Email;
							Navigation.PopAsync();
						}
					}
				} else {
					await DisplayAlert ("Ugyldig email", "Emailen har ikke et gyldigt format", "OK");
				}
			} else {
				await DisplayAlert ("Ugyldig data", "Noget data var indtastet forkert, orøv igen", "OK");
			}
		}

		//validate email (taken from: http://msdn.microsoft.com/en-us/library/01escwtf(v=vs.110).aspx)
		public bool IsValidEmail(string strIn)
		{
			invalidEmail = false;
			if (String.IsNullOrEmpty(strIn))
				return false;

			// Use IdnMapping class to convert Unicode domain names. 
			try {
				strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper,
					RegexOptions.None, TimeSpan.FromMilliseconds(200));
			}
			catch (RegexMatchTimeoutException) {
				return false;
			}

			if (invalidEmail)
				return false;

			// Return true if strIn is in valid e-mail format. 
			try {
				return Regex.IsMatch(strIn,
					@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
					@"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
					RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
			}
			catch (RegexMatchTimeoutException) {
				return false;
			}
		}

		private string DomainMapper(Match match)
		{
			// IdnMapping class with default property values.
			IdnMapping idn = new IdnMapping();

			string domainName = match.Groups[2].Value;
			try {
				domainName = idn.GetAscii(domainName);
			}
			catch (ArgumentException) {
				invalidEmail = true;
			}
			return match.Groups[1].Value + domainName;
		}
	}
}

