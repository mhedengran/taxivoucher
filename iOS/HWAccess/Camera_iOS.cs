using System;
using Xamarin.Media;
using Xamarin.Forms;
using TaxiPay.iOS;

[assembly: Dependency (typeof (Camera_iOS))]
namespace TaxiPay.iOS
{
	public class Camera_iOS : ICamera
	{
		public Camera_iOS () {}

		public MediaPicker GetPicker () {
			return new MediaPicker ();
		}
	}
}

