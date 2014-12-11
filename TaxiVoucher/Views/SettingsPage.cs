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

		TextEntry emailEntry;
		TextEntry password1Entry;
		TextEntry password2Entry;
		TextEntry swiftEntry;
		TextEntry ibanEntry;

		bool invalidEmail;

		public SettingsPage (Driver drvr)
		{
			driver = drvr;

			Title = "Indstillinger";
			BackgroundColor = Color.FromHex (Colors.backgroundColor);

			EntryLayout emailLayout = new EntryLayout ();
			StackLayout emailField;
			if (driver.Email.Length > 0) {
				emailField = emailLayout.GetLayoutWithIcon ("E-mail", driver.Email, Keyboard.Email, IconStrings.atIcon, false);
			} else {
				emailField  = emailLayout.GetLayoutWithIcon ("E-mail", "", Keyboard.Email, IconStrings.atIcon, false);
			}
			emailEntry = emailLayout.TextEntry;



			EntryLayout password1Layout = new EntryLayout ();
			StackLayout password1Field = password1Layout.GetLayoutWithIcon ("Skriv password", "", Keyboard.Create (0x00), IconStrings.lockIcon, true);
			password1Entry = password1Layout.TextEntry;

			EntryLayout password2Layout = new EntryLayout ();
			StackLayout password2Field = password1Layout.GetLayoutWithIcon ("Skriv password igen", "", Keyboard.Create (0x00), IconStrings.lockIcon, true);
			password2Entry = password2Layout.TextEntry;

			EntryLayout swiftLayout = new EntryLayout ();
			StackLayout swiftField;
			if (driver.BankAccount.Swift.Length > 0) {
				swiftField = swiftLayout.GetLayoutWithIcon ("Swift/BIC", driver.BankAccount.Swift, Keyboard.Default, IconStrings.moneyIcon, false);
			} else {
				swiftField = swiftLayout.GetLayoutWithIcon ("Swift/BIC", "", Keyboard.Default, IconStrings.moneyIcon, false);
			}
			swiftEntry = swiftLayout.TextEntry;
			swiftField.VerticalOptions = LayoutOptions.End;


			EntryLayout ibanLayout = new EntryLayout ();
			StackLayout ibanField;
			if (driver.BankAccount.Iban.Length > 0) {
				ibanField = ibanLayout.GetLayoutWithIcon ("IBAN", driver.BankAccount.Iban, Keyboard.Default, IconStrings.moneyIcon, false);
			} else {
				ibanField = ibanLayout.GetLayoutWithIcon ("IBAN", "", Keyboard.Default, IconStrings.moneyIcon, false);
			}
			ibanEntry = ibanLayout.TextEntry;
			ibanField.VerticalOptions = LayoutOptions.End;


			NormalButton saveButton = new NormalButton {
				Text = "Gem",
				ArrowPositionRight = true,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.EndAndExpand,
				HeightRequest = 40,
			};
			saveButton.Clicked += OnSaveClicked;

			StackLayout stacklayout = new StackLayout {
				Spacing = 10,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness (30, 30, 30, 30),
				Children = {

					new Label {
						Text = driver.ExternalReference,
						TextColor = Color.FromHex(Colors.textColor),
						VerticalOptions = LayoutOptions.Center,
						HorizontalOptions = LayoutOptions.Start
					},

					emailField,
					password1Field,
					password2Field,

					new Label {
						Text = "Bankoplysninger",
						TextColor = Color.FromHex(Colors.textColor),
						VerticalOptions = LayoutOptions.EndAndExpand,
						HorizontalOptions = LayoutOptions.Start
					},

					swiftField,
					ibanField,

					saveButton,
				}
			};
			ScrollView view = new ScrollView {
				Content = stacklayout
			};
			Content = view;
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
							await Navigation.PopAsync();
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

