using System;
using Android.App;
using Android.Preferences;
using Android.Content;

namespace TaxiPay.Android
{
	public class UserPrefences_Android : IUserPreferences
	{
		public void SetString(string key, string value)
		{
			var prefs = Application.Context.GetSharedPreferences("MySharedPrefs", FileCreationMode.Private);
			var prefsEditor = prefs.Edit();

			prefsEditor.PutString(key, value);
			prefsEditor.Apply();
		}

		public string GetString(string key)
		{
			var prefs = Application.Context.GetSharedPreferences("MySharedPrefs", FileCreationMode.Private);
			return prefs.GetString (key, "");
		}
	}
}

