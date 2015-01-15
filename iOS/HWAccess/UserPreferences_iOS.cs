using System;
using MonoTouch.Foundation;

namespace TaxiPay.iOS
{
	public class UserPreferences_iOS : IUserPreferences
	{
		public void SetString(string key, string value)
		{
			NSUserDefaults.StandardUserDefaults.SetString(value, key);
		}

		public string GetString(string key)
		{
			return NSUserDefaults.StandardUserDefaults.StringForKey (key);
		}
	}
}

