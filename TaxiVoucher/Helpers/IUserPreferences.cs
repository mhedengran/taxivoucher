using System;
using Xamarin.Forms;

namespace TaxiPay
{
	public interface IUserPreferences
	{
		void SetString(string key, string value);
		string GetString(string key);
	}
}

