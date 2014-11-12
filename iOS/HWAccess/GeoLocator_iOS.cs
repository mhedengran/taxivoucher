using System;
using Xamarin.Geolocation;
using Xamarin.Forms;
using TaxiPay.iOS;

[assembly: Dependency (typeof (GeoLocator_iOS))]
namespace TaxiPay.iOS
{
	public class GeoLocator_iOS : IGeoLocator
	{
		public GeoLocator_iOS () {}

		public Geolocator GetLocator() {
			return new Geolocator { DesiredAccuracy = 50 };
		}
	}
}

