using System;
using Xamarin.Forms;
using Xamarin.Media;
using TaxiVoucher.Android;

[assembly: Dependency (typeof (Camera_Android))]
namespace TaxiVoucher.Android
{
	public class Camera_Android : ICamera
	{
		public Camera_Android () {}

		public MediaPicker GetPicker () {
			return new MediaPicker (Forms.Context);
		}
	}
}

