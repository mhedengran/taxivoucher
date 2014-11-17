using System;
using Xamarin.Geolocation;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TaxiPay
{
	public class Location
	{
		public double Latitude { get; set; }
		public double Longtitude { get; set; }

		public Location (double lat, double lng) {
			Latitude = lat;
			Longtitude = lng;
		}

		public Location () {
			Latitude = 0;
			Longtitude = 0;
		}
	}
}

