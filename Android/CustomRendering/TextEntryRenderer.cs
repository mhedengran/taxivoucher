using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using TaxiPay;
using TaxiPay.Android;

[assembly: ExportRenderer (typeof (TextEntry), typeof (TextEntryRenderer))]
namespace TaxiPay.Android
{
	public class TextEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);
			if (e.OldElement == null) {
				var nativeEditText = (global::Android.Widget.EditText)Control;
				nativeEditText.SetBackgroundColor (global::Android.Graphics.Color.White);
				nativeEditText.SetTextColor (global::Android.Graphics.Color.ParseColor (Colors.textColor));
			}
		}
	}
}

