using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using TaxiPay;
using TaxiPay.Android;

[assembly: ExportRenderer (typeof (MenuButton), typeof (MenuButtonRenderer))]
namespace TaxiPay.Android
{
	public class MenuButtonRenderer : ButtonRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged (e);
			if (e.OldElement == null) {
				var nativeButton = (global::Android.Widget.Button)Control;
				var button = (MenuButton)this.Element;

				int height = (int)button.HeightRequest;
				int fontSize = Math.Max (height / 3, 16);

				if (button.Icon.Length > 0) {
					nativeButton.SetText(button.LabelText, global::Android.Widget.TextView.BufferType.Normal);
					nativeButton.SetTextSize (global::Android.Util.ComplexUnitType.Dip ,fontSize);
					nativeButton.SetTextColor (global::Android.Graphics.Color.White);
				} else {
					button.Text = button.LabelText;
					button.Font = Font.SystemFontOfSize (fontSize);
					button.TextColor = Color.White;
				}
				nativeButton.SetBackgroundResource (Resource.Drawable.menuButtonBackground);
			}
		}
	}
}

