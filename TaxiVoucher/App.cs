using System;
using Xamarin.Forms;

namespace TaxiPay
{
	public class App
	{
		public static IUserPreferences UserPreferences { get; private set; }

		public static void Init(IUserPreferences userPreferencesImpl) 
		{
			App.UserPreferences = userPreferencesImpl;
		}

		public static Page GetMainPage ()
		{	
			var login = new LoginPage();

			return new NavigationPage(login) {
				BarBackgroundColor = Color.FromHex(Colors.menuButtonColor),
				BarTextColor = Color.White,
			};
		}
	}
}

