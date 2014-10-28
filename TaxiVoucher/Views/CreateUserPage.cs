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

			Image driverCardImage = new Image {
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.EndAndExpand,
				BackgroundColor = Color.Accent,
				Aspect = Aspect.AspectFit,
				HeightRequest = Device.OnPlatform( 80.0, 80.0, 80.0, 80.0),
				WidthRequest = Device.OnPlatform(80.0, 80.0, 80.0, 80.0),
				Source = ImageSource.FromUri(new Uri("http://icons.iconarchive.com/icons/martz90/circle/512/camera-icon.png")),
			};
			var imageTapRecognizer = new TapGestureRecognizer {
				TappedCallback = (v, o) => {
					ImageTapped();
				},
				NumberOfTapsRequired = 1
			};
			driverCardImage.GestureRecognizers.Add (imageTapRecognizer);

			Button createUserButton = new Button {
				Text = "Create user",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.EndAndExpand
			};
			createUserButton.Clicked += OnCreateUserClicked;

			StackLayout stacklayout = new StackLayout {
				Spacing = 10,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness (20, 100, 20, 10),
				Children = {
					new Entry {
						Keyboard = Keyboard.Email,
						Placeholder = "E-mail",
						IsPassword = true,
						VerticalOptions = LayoutOptions.Center
					},

					new Entry {
						Keyboard = Keyboard.Numeric,
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
					},

					new Label
					{
						Text = "Picture of drivercard",
						HorizontalOptions = LayoutOptions.StartAndExpand,
						VerticalOptions = LayoutOptions.Center
					},

					driverCardImage,
					createUserButton,
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
				Console.WriteLine ("Switch on");
			} else {
				Console.WriteLine ("Switch off");
			}	
		}

		void ImageTapped() {
			Console.WriteLine ("Image clicked");
		}

		void OnCreateUserClicked(object sender, EventArgs e) 
		{
			Navigation.PushAsync(new CreateUserPage());
		}
	}
}

