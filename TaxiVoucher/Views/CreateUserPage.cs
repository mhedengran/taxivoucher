using System;
using Xamarin.Forms;
using Xamarin.Media;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace TaxiPay
{
	public class CreateUserPage : ContentPage
	{
		Image driverCardImage;
		Entry emailEntry;
		Entry driverNumberEntry;
		Entry password1Entry;
		Entry password2Entry;

		bool invalidEmail;

		public CreateUserPage ()
		{
			Title = "Opret bruger";

			emailEntry = new Entry {
				Text = "",
				Keyboard = Keyboard.Email,
				Placeholder = "E-mail",
				VerticalOptions = LayoutOptions.Center
			};

			driverNumberEntry = new Entry {
				Text = "",
				Keyboard = Keyboard.Numeric,
				Placeholder = "Fører numer",
				VerticalOptions = LayoutOptions.Center
			};

			password1Entry = new Entry {
				Text = "",
				Keyboard = Keyboard.Create (0x00),
				Placeholder = "Skriv password",
				IsPassword = true,
				VerticalOptions = LayoutOptions.Center
			};

			password2Entry = new Entry {
				Text = "",
				Keyboard = Keyboard.Create (0x00),
				Placeholder = "Skriv password igen",
				IsPassword = true,
				VerticalOptions = LayoutOptions.Center
			};

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
					emailEntry,
					driverNumberEntry,
					password1Entry,
					password2Entry,

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

		async void OnCreateUserClicked(object sender, EventArgs e) 
		{





			if (IsValidEmail (emailEntry.Text)) {
				if (password1Entry.Text.Equals (password2Entry.Text) && password1Entry.Text.Length > 0) {
					if (driverNumberEntry.Text.Length > 0) {
						//CommunicationHelper comm = new CommunicationHelper ();
						//var createUserTask = comm.CreateUser (emailEntry.Text, driverNumberEntry.Text, password1Entry.Text);
						//Console.WriteLine (createUserTask.Result);
						//if ok send picture and update driverNumber
						//create vehicle for driver
						//var createCarTask = comm.CreateCar ();
						//Console.WriteLine (createCarTask.Result);
						//Navigation.PushAsync (new VerifyEmailPage());
					} else {
						await DisplayAlert ("Ugyldig data", "Noget data var indtastet forkert, orøv igen", "OK");
					}
				} else {
					await DisplayAlert ("Fejlindtastning", "De to indtastede kodeord, matcher ikke", "OK");
				}
			} else {
				await DisplayAlert ("Ugyldig email", "Emailen har ikke et gyldigt format", "OK");
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

