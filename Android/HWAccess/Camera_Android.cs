using System;
using Xamarin.Forms;
using Xamarin.Media;
using TaxiPay.Android;

[assembly: Dependency (typeof (Camera_Android))]
namespace TaxiPay.Android
{
	public class Camera_Android : ICamera
	{
		public Camera_Android () {}

		public MediaPicker GetPicker () {
			return new MediaPicker (Forms.Context);
		}
	}
}

