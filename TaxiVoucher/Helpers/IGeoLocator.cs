using System;
using Xamarin.Geolocation;

namespace TaxiPay
{
	public interface IGeoLocator
	{
		Geolocator GetLocator ();
	}
}

