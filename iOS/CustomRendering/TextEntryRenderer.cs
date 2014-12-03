using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using MonoTouch.UIKit;
using TaxiPay;
using TaxiPay.iOS;

[assembly: ExportRenderer (typeof (TextEntry), typeof (TextEntryRenderer))]

namespace TaxiPay.iOS
{
	public class TextEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);
			if (e.OldElement == null) { 
				var nativeTextField = (UITextField) Control;

				nativeTextField.BackgroundColor = UIColor.White;
				nativeTextField.BorderStyle = UITextBorderStyle.None;
				nativeTextField.TextAlignment = UITextAlignment.Left;
				nativeTextField.TextColor = UIColor.FromRGB (0x44, 0x44, 0x44);
			}
		}
	}
}

