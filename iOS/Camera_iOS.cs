using System;
using Xamarin.Media;
using Xamarin.Forms;
using TaxiVoucher.iOS;

[assembly: Dependency (typeof (Camera_iOS))]
namespace TaxiVoucher.iOS
{
	public class Camera_iOS : ICamera
	{
		public Camera_iOS () {}

		public MediaPicker GetPicker () {
			return new MediaPicker ();
		}
	}
}

