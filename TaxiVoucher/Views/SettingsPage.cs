﻿using System;
using Xamarin.Forms;

namespace TaxiVoucher
{
	public class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			Title = "Settings";

			//init picker
			Picker picker = new Picker
			{
				Title = "Taxi-Company"
			};

			for (int i = 0; i < 10; i++)
			{
				picker.Items.Add("test"+i);
			}

			picker.SelectedIndexChanged += PickerSelectedIndexChanged;

			//init switch
			Switch loginSwitch = new Switch
			{
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.Center
			};
			loginSwitch.Toggled += LoginSwitchToggled;

			Switch emailSwitch = new Switch
			{
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.Center
			};
			emailSwitch.Toggled += EmailSwitchToggled;

			Button saveButton = new Button {
				Text = "Save",
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
						Text = "Driver number",
						VerticalOptions = LayoutOptions.Center,
						HorizontalOptions = LayoutOptions.Start
					},

					new Entry {
						Keyboard = Keyboard.Email,
						Placeholder = "E-mail",
						VerticalOptions = LayoutOptions.Start,
					},

					new Entry {
						Keyboard = Keyboard.Create(0x00),
						Placeholder = "Enter password",
						IsPassword = true,
						VerticalOptions = LayoutOptions.Start
					},

					new Entry {
						Keyboard = Keyboard.Create(0x00),
						Placeholder = "Enter password again",
						IsPassword = true,
						VerticalOptions = LayoutOptions.Start
					},

					picker,
					new StackLayout
					{
						Spacing = 10,
						Orientation = StackOrientation.Horizontal,
						HorizontalOptions = LayoutOptions.FillAndExpand,
						Children = 
						{
							new Label
							{
								Text = "Login automatically",
								HorizontalOptions = LayoutOptions.StartAndExpand,
								VerticalOptions = LayoutOptions.Center
							},
							loginSwitch,

						}
					},

					new StackLayout
					{
						Spacing = 10,
						Orientation = StackOrientation.Horizontal,
						HorizontalOptions = LayoutOptions.FillAndExpand,
						Children = 
						{
							new Label
							{
								Text = "Send receipt automatically",
								HorizontalOptions = LayoutOptions.StartAndExpand,
								VerticalOptions = LayoutOptions.Center
							},
							emailSwitch,

						}
					},

					new Entry {
						Keyboard = Keyboard.Numeric,
						Placeholder = "Swift/BIC",
						VerticalOptions = LayoutOptions.EndAndExpand,
					},

					new Entry {
						Keyboard = Keyboard.Numeric,
						Placeholder = "IBAN",
						VerticalOptions = LayoutOptions.End,
					},

					saveButton,
				}
			};
			Content = stacklayout;
		}

		void PickerSelectedIndexChanged(object sender, EventArgs e) {
			Picker picker = (Picker)sender;
			if (picker.SelectedIndex == 1) {
			}
		}

		void LoginSwitchToggled(object sender, ToggledEventArgs e) {
			if (e.Value) {
				Console.WriteLine ("Switch on");
			} else {
				Console.WriteLine ("Switch off");
			}	
		}

		void EmailSwitchToggled(object sender, ToggledEventArgs e) {
			if (e.Value) {
				Console.WriteLine ("Switch on");
			} else {
				Console.WriteLine ("Switch off");
			}	
		}

		void OnSaveClicked(object sender, EventArgs e) 
		{
			//save data
			Navigation.PopAsync();
		}
	}
}
