using System;
using Xamarin.Geolocation;
using Xamarin.Forms;
using TaxiPay.Android;

[assembly: Dependency (typeof (GeoLocator_Android))]
namespace TaxiPay.Android
{
	public class GeoLocator_Android : IGeoLocator
	{
		public GeoLocator_Android () {}

		public Geolocator GetLocator() {
			return new Geolocator (Forms.Context) { DesiredAccuracy = 50 };
		}
	}
}

