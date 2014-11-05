using System;
using Xamarin.Media;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace TaxiVoucher
{
	public class CameraHelper
	{
		MediaPicker cameraPicker;
		public MediaFile file;
//		DisposingMediaViewController dialogController;

		public CameraHelper ()
		{
			Device.OnPlatform(
				Default: () => cameraPicker = new MediaPicker()
			);
		}

		public void pickPhoto () {
			//pick photo
			Device.OnPlatform(
				Default: () => cameraPicker.PickPhotoAsync().ContinueWith (t => {
					file = t.Result;
					Console.WriteLine (file.Path);
				}, TaskScheduler.FromCurrentSynchronizationContext())
			);
		}

		public async void takePhoto () {
			//take photo
			if (Device.OS == TargetPlatform.Android) {
				
			} else {
				file =  await cameraPicker.TakePhotoAsync (new StoreCameraMediaOptions {
					Name = "test.jpg",
					Directory = "MediaPickerSample"
				});
			}
//			Device.OnPlatform(
//				Default: () => task = cameraPicker.TakePhotoAsync (new StoreCameraMediaOptions {
//					Name = "test.jpg",
//					Directory = "MediaPickerSample"
//				}).ContinueWith (t => {
//					file = t.Result;
//					Console.WriteLine (file.Path);
//				}, TaskScheduler.FromCurrentSynchronizationContext())
//			);
		}
	}
}

