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

//				nativeTextField.EdgeInsets = new UIEdgeInsets (0, 10, 0, 10);
				var rect = nativeTextField.Frame;
				nativeTextField.Frame = new System.Drawing.RectangleF (rect.X + 10, rect.Y, rect.Width - 10, rect.Height);
				nativeTextField.BackgroundColor = UIColor.White;
				nativeTextField.BorderStyle = UITextBorderStyle.None;
				nativeTextField.TextAlignment = UITextAlignment.Left;
				SetNeedsDisplay ();
			}
		}
	}
}

