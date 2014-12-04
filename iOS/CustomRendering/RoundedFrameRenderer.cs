using System;
using System.Collections.Generic;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using TaxiPay;
using TaxiPay.iOS;
using System.Drawing;

[assembly: ExportRenderer (typeof (RoundedFrame), typeof (RoundedFrameRenderer))]
namespace TaxiPay.iOS
{
	public class RoundedFrameRenderer : FrameRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Frame> e) {
			base.OnElementChanged (e);
			if (e.OldElement == null) { 
				var nativeLayout = (UIView)NativeView;
				nativeLayout.Layer.CornerRadius = 15;
			}
		}
	}
}
