using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android;
using TaxiPay;
using TaxiPay.Android;

[assembly: ExportRenderer (typeof (NormalButton), typeof (NormalButtonRenderer))]
namespace TaxiPay.Android
{
	public class NormalButtonRenderer : ButtonRenderer
	{

//
//		protected override void DispatchDraw (global::Android.Graphics.Canvas canvas) {
//			base.DispatchDraw (canvas);
//			Console.WriteLine ("a" + Control.Height + " " + Control.Width);
//			var nativeButton = (global::Android.Widget.Button)Control;
//			
//		}
//
//		public override SizeRequest GetDesiredSize (int widthConstraint, int heightConstraint) {
//			Console.WriteLine ("b" + Control.Height + " " + Control.Width);
//			Console.WriteLine ("c" + heightConstraint + " " + widthConstraint);
//			return base.GetDesiredSize (widthConstraint, heightConstraint);
//		}

		protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged (e);
			if (e.OldElement == null) {
				var nativeButton = (global::Android.Widget.Button)Control;
				var button = (NormalButton)this.Element;

				int height = (int)button.HeightRequest;
//				NormalButtonAndroid newButton = new NormalButtonAndroid (Forms.Context);

//				global::Android.Graphics.Drawables.Drawable arrow = new TextDrawable(IconStrings.arrowRightIcon);
//				nativeButton.SetCompoundDrawablesWithIntrinsicBounds(null,null, arrow ,null);
//				global::Android.Widget.ImageView imageView = new global::Android.Widget.ImageView (Forms.Context);
//				imageView.SetImageDrawable (arrow);
//				this.AddView (imageView);

//				try Image button
//				SetNativeControl (newButton);

				nativeButton.SetTextSize (global::Android.Util.ComplexUnitType.Dip ,Math.Max (height / 3, 16));

				nativeButton.SetBackgroundResource (Resource.Drawable.normalButtonBackground);
				nativeButton.SetTextColor (global::Android.Graphics.Color.ParseColor (Colors.textColor));
			}
		}
	}
}

