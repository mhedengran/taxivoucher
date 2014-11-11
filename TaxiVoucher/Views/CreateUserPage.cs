using System;
using Xamarin.Forms;
using Xamarin.Media;
using System.Threading.Tasks;
//using Android;

namespace TaxiVoucher
{
	public class CreateUserPage : ContentPage
	{
		Image driverCardImage;

		public CreateUserPage ()
		{
			Title = "Opret bruger";

			//init switch
			Switch switcher = new Switch
			{
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.Center
			};
			switcher.Toggled += SwitcherToggled;

			driverCardImage = new Image {
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.EndAndExpand,
				Aspect = Aspect.AspectFit,
				Source = ImageSource.FromUri(new Uri("http://icons.iconarchive.com/icons/martz90/circle/512/camera-icon.png")),
			};
			Device.OnPlatform(
				iOS: () => driverCardImage.HeightRequest = 80,
				Android: () => driverCardImage.HeightRequest = 80
			);
			Device.OnPlatform(
				iOS: () => driverCardImage.WidthRequest = 80,
				Android: () => driverCardImage.WidthRequest = 80
			);

			var imageTapRecognizer = new TapGestureRecognizer {
				Command = new Command (() => {
					ImageTapped();
				}),
				NumberOfTapsRequired = 1
			};
			driverCardImage.GestureRecognizers.Add (imageTapRecognizer);

			Button createUserButton = new Button {
				Text = "Opret bruger",
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
						VerticalOptions = LayoutOptions.Center
					},

					new Entry {
						Keyboard = Keyboard.Numeric,
						Placeholder = "Fører numer",
						VerticalOptions = LayoutOptions.Center
					},

					new Entry {
						Keyboard = Keyboard.Create(0x00),
						Placeholder = "Skriv password",
						IsPassword = true,
						VerticalOptions = LayoutOptions.Center
					},

					new Entry {
						Keyboard = Keyboard.Create(0x00),
						Placeholder = "Skriv password igen",
						IsPassword = true,
						VerticalOptions = LayoutOptions.Center
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
								Text = "Login automatisk",
								HorizontalOptions = LayoutOptions.StartAndExpand,
								VerticalOptions = LayoutOptions.Center
							},
							switcher,

						}
					},

					new Label
					{
						Text = "Billede af førerkort",
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

		//move logic to seperate class should properly be platform specific
		async void ImageTapped () {
			MediaPicker cameraPicker = DependencyService.Get<ICamera> ().GetPicker();
			Console.WriteLine ("Image clicked");

				var action = await DisplayActionSheet (null, "Annuller", null, "Tag billede", "Vælg fra eksisterende");
				//bug fix...
				await Task.Delay (500);

			if (action.Equals ("Tag billede")) {
				if (cameraPicker.IsCameraAvailable) {
					Device.OnPlatform (
						Default: () => cameraPicker.TakePhotoAsync (new StoreCameraMediaOptions {
							Name = "driverCardImage.jpg",
							Directory = "MediaPickerSample"
						}).ContinueWith (t => {
							MediaFile file = t.Result;	
							Console.WriteLine (file.Path);
							driverCardImage.Source = ImageSource.FromFile (file.Path);
						}, TaskScheduler.FromCurrentSynchronizationContext ()
						)
					);
				} else {
					await DisplayAlert ("Intet kamera", "Din telefon har ikke et kamera", "OK");
				}
			} else { 
				Device.OnPlatform (
					Default: () => cameraPicker.PickPhotoAsync ().ContinueWith (t => {
						MediaFile file = t.Result;
						Console.WriteLine (file.Path);
						driverCardImage.Source = ImageSource.FromFile (file.Path);
					}, TaskScheduler.FromCurrentSynchronizationContext ())
				);
			}
		}

		void OnCreateUserClicked(object sender, EventArgs e) 
		{
			Navigation.PushAsync (new VerifyEmailPage());
		}
	}
}

