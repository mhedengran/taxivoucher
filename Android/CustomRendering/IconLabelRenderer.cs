using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Widget;
using Android.Graphics;
using TaxiPay;
using TaxiPay.Android;

[assembly: ExportRenderer (typeof (IconLabel), typeof (IconLabelRenderer))]
namespace TaxiPay.Android
{
	public class IconLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Label> e) {
			base.OnElementChanged (e);
			var label = (TextView) Control; // for example
			Typeface font = Typeface.CreateFromAsset (Forms.Context.Assets, "FontAwesome.otf");
			label.Typeface = font;
		}
	}
}