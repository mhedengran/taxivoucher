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
		TextEntry emailEntry;
		TextEntry driverNumberEntry;
		TextEntry password1Entry;
		TextEntry password2Entry;
		Label PictureLabel;

		bool invalidEmail;

		public CreateUserPage ()
		{
			Title = "Opret bruger";
			BackgroundColor = Color.FromHex (Colors.backgroundColor);

			EntryLayout emailLayout = new EntryLayout ();
			StackLayout emailField = emailLayout.GetLayoutWithIcon ("E-mail", "", Keyboard.Email, IconStrings.atIcon, false);
			emailEntry = emailLayout.TextEntry;
			
			EntryLayout driverNumberLayout = new EntryLayout ();
			StackLayout driverNumberField = driverNumberLayout.GetLayoutWithIcon ("Fører nummer", "", Keyboard.Numeric, IconStrings.cabIcon, false);
			driverNumberEntry = driverNumberLayout.TextEntry;

			EntryLayout password1Layout = new EntryLayout ();
			StackLayout password1Field = password1Layout.GetLayoutWithIcon ("Skriv password", "", Keyboard.Create (0x00), IconStrings.lockIcon, true);
			password1Entry = password1Layout.TextEntry;

			EntryLayout password2Layout = new EntryLayout ();
			StackLayout password2Field = password2Layout.GetLayoutWithIcon ("Skriv password igen", "", Keyboard.Create (0x00), IconStrings.lockIcon, true);
			password2Entry = password2Layout.TextEntry;

			MenuButton takePictureButton = new MenuButton {
				LabelText = "Tag billede af førerkort",
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.Center,
				HeightRequest = Device.OnPlatform(30,40,30)

			};
			takePictureButton.Clicked += OnTakePictureClicked;

			driverCardImage = new Image {
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.EndAndExpand,
				Aspect = Aspect.AspectFit,
//				Source = ImageSource.FromFile("CameraIcon.gif")
//				Source = ImageSource.FromUri(new Uri("http://icons.iconarchive.com/icons/martz90/circle/512/camera-icon.png")),
			};

			NormalButton createUserButton = new NormalButton {
				Text = "Opret bruger",
				ArrowPositionRight = true,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.End,
				HeightRequest = 40
			};
			createUserButton.Clicked += OnCreateUserClicked;

			PictureLabel = new Label {
				Text = "Billede af førerkort",
				HorizontalOptions = LayoutOptions.StartAndExpand,
				VerticalOptions = LayoutOptions.Center,
				IsVisible = false
			};

			StackLayout stacklayout = new StackLayout {
				BackgroundColor = Color.FromHex( Colors.backgroundColor),
				Spacing = 10,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness (30, 30, 30, 30),
				Children = {
					emailField,
					driverNumberField,
					password1Field,
					password2Field,

					takePictureButton,
					PictureLabel,
					driverCardImage,
					createUserButton,
				}
			};
			ScrollView view = new ScrollView {
				Content = stacklayout
			};
			Content = view;
		}

		async void OnTakePictureClicked(object sender, EventArgs e) {
			MediaPicker cameraPicker = DependencyService.Get<ICamera> ().GetPicker();
			Console.WriteLine ("Image clicked");

			var action = await DisplayActionSheet ("Vælg funktion", "Annuller", null, "Tag billede", "Vælg fra eksisterende");
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
					PictureLabel.IsVisible = true;
				} else {
					await DisplayAlert ("Intet kamera", "Din telefon har ikke et kamera", "OK");
				}
			} else if (action.Equals("Vælg fra eksisterende")) { 
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
			await DisplayAlert ("OBS", "Dette kald er ikke færdigimplementeret", "OK");
//			if (IsValidEmail (emailEntry.Text)) {
//				if (password1Entry.Text.Equals (password2Entry.Text) && password1Entry.Text.Length > 0) {
//					if (driverNumberEntry.Text.Length > 0) {
//						//få implementeret så det er okay hvis den fejler undervejs
//						CommunicationHelper comm = new CommunicationHelper ();
//						var createUserTask = comm.CreateUser (emailEntry.Text, driverNumberEntry.Text, password1Entry.Text);
//						string createResult = createUserTask.Result;
//						Console.WriteLine (createResult);
//						if (createResult.Contains("firstName")) {
//							var loginTask = comm.Login (emailEntry.Text, password1Entry.Text);
//							JSONResponse loginResponse = loginTask.Result;
//							if (loginResponse.SystemMessage != null) {
//								await DisplayAlert ("Login fejl", "Prøv igen om lidt", "OK");
//							} else {
//								Driver drvr = loginResponse.Driver;
//								drvr.Token = loginResponse.Token;
//								drvr.ExternalReference = driverNumberEntry.Text;
//								var updateDrvrTask = comm.UpdateDriver(drvr, drvr.Id, drvr.Token);
//								Driver newDrvr = updateDrvrTask.Result;
//								if (newDrvr.Id.Length < 1) {
//									await DisplayAlert ("Ups", "Noget gik galt, tjek signalet og prøv igen", "OK");
//								} else {
//									//upload image
//									//create vehicle for driver
//									//var createCarTask = comm.CreateCar ();
//									//Console.WriteLine (createCarTask.Result);
//									await Navigation.PushAsync (new VerifyEmailPage());
//								}
//							}
//						} else {
//							await DisplayAlert ("Email", "Email er allerede i brug", "OK");
//						}	
//					} else {
//						await DisplayAlert ("Ugyldig data", "Noget data var indtastet forkert, prøv igen", "OK");
//					}
//				} else {
//					await DisplayAlert ("Fejlindtastning", "De to indtastede kodeord, matcher ikke", "OK");
//				}
//			} else {
//				await DisplayAlert ("Ugyldig email", "Emailen har ikke et gyldigt format", "OK");
//			}
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

