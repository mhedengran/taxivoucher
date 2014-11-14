using System;
using Xamarin.Forms;

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

		public SettingsPage (Driver drvr)
		{
			driver = drvr;

			Title = "Indstillinger";

			emailEntry = new Entry {
				Keyboard = Keyboard.Email,
				VerticalOptions = LayoutOptions.Start,
			};

			password1Entry = new Entry {
				Keyboard = Keyboard.Create (0x00),
				Placeholder = "Skriv password",
				IsPassword = true,
				VerticalOptions = LayoutOptions.Start
			};

			password2Entry = new Entry {
				Keyboard = Keyboard.Create (0x00),
				Placeholder = "Skriv password igen",
				IsPassword = true,
				VerticalOptions = LayoutOptions.Start
			};

			swiftEntry = new Entry {
				Keyboard = Keyboard.Numeric,
				Placeholder = "Swift/BIC",
				VerticalOptions = LayoutOptions.EndAndExpand,
			};

//			if (driver.Swift != null) {
				swiftEntry.Text = driver.Swift;
//			}

			ibanEntry = new Entry {
				Keyboard = Keyboard.Numeric,
				Placeholder = "IBAN",
				VerticalOptions = LayoutOptions.End,
			};

//			if (driver.Iban != null) {
				ibanEntry.Text = driver.Iban;
//			}

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
						Text = driver.DriverNumber,
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

		void OnSaveClicked(object sender, EventArgs e) 
		{
			//save data
			if (!driver.Email.Equals(emailEntry.Text) ||
				(password1Entry.Text.Equals(password2Entry.Text) && password1Entry.Text.Length > 0) ||
				!driver.Swift.Equals(swiftEntry.Text) ||
				!driver.Iban.Equals(ibanEntry.Text)) 
			{

			}

			Navigation.PopAsync();
		}
	}
}

