using System;
using Xamarin.Forms;

namespace TaxiVoucher
{
	public class CreateUserPage : ContentPage
	{
		public CreateUserPage ()
		{
			Title = "Create user";

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
			Switch switcher = new Switch
			{
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.Center
			};
			switcher.Toggled += SwitcherToggled;

			StackLayout stacklayout = new StackLayout {
				Spacing = 10,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness (20, 100, 20, 10),
				Children = {
					new Entry {
						Keyboard = Keyboard.Text,
						Placeholder = "Driver number",
						IsPassword = true,
						VerticalOptions = LayoutOptions.Center
					},

					new Entry {
						Keyboard = Keyboard.Text,
						Placeholder = "Enter password",
						IsPassword = true,
						VerticalOptions = LayoutOptions.Center
					},

					new Entry {
						Keyboard = Keyboard.Text,
						Placeholder = "Enter password again",
						IsPassword = true,
						VerticalOptions = LayoutOptions.Center
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
							switcher,

						}
					}


				}
			};
			Content = stacklayout;
		}

		void PickerSelectedIndexChanged(object sender, EventArgs e) {
			Picker picker = (Picker)sender;
			if (picker.SelectedIndex == 1) {
			}
		}

		void SwitcherToggled(object sender, ToggledEventArgs e) {
			if (e.Value) {
			
			} else {

			}
		}
	}
}

