using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Text;
using Android.Text.Style;
using Android.Graphics;
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
				int fontSize = (int)Math.Max (height / 2.5, 16);
				Typeface font = Typeface.CreateFromAsset (Forms.Context.Assets, "FontAwesome.otf");
				if (button.Icon.Length > 0) {
					button.Text = "  " + button.Icon + "  " + button.LabelText;
					nativeButton.SetTypeface (font, TypefaceStyle.Normal);
					nativeButton.SetTextSize (global::Android.Util.ComplexUnitType.Dip ,fontSize);
					nativeButton.Gravity = global::Android.Views.GravityFlags.CenterVertical;
				} else {
					button.Text = button.LabelText;
					button.Font = Font.SystemFontOfSize (fontSize);
				}
				button.TextColor = Xamarin.Forms.Color.White;
				nativeButton.SetBackgroundResource (Resource.Drawable.menuButtonBackground);
			}
		}
	}
}

