using System;
using Xamarin.Forms;

namespace TaxiPay
{
	public class App
	{
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

