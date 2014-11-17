using System;
using RestSharp;
using System.Threading.Tasks;
using Xamarin.Geolocation;
using Xamarin.Forms;

namespace TaxiPay
{
	public class GeoLocator
	{
		public async Task<Location> GetLocation() {
//			var tcs = new TaskCompletionSource<Location> ();
			Location loc = new Location (0,0);
			Geolocator locator = DependencyService.Get<IGeoLocator> ().GetLocator();
			Console.WriteLine ("available:" + locator.IsGeolocationAvailable);
			Console.WriteLine ("enabled:" + locator.IsGeolocationEnabled);
			await locator.GetPositionAsync (timeout: 100000).ContinueWith (t => {
				if (t.Status.ToString().Equals("RanToCompletion")) {
					Console.WriteLine ("Position Status: {0}", t.Status.ToString()); //if != RanToCompletion do something
					Console.WriteLine ("Position Latitude: {0}", t.Result.Latitude);
					Console.WriteLine ("Position Longitude: {0}", t.Result.Longitude);
//					tcs.SetResult(new Location(t.Result.Latitude, t.Result.Longitude));
					loc.Latitude = t.Result.Latitude;
					loc.Longtitude = t.Result.Longitude;
				}
			}, TaskScheduler.FromCurrentSynchronizationContext());
//			return tcs.Task;
			return loc;
		}
	}
}

