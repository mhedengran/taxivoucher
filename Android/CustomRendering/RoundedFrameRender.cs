using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android;
using Android.Graphics;
using Android.Graphics.Drawables.Shapes;
using TaxiPay;
using TaxiPay.Android;

[assembly: ExportRenderer (typeof (RoundedFrame), typeof (RoundedFrameRender))]
namespace TaxiPay.Android
{
	public class RoundedFrameRender : FrameRenderer
	{
		public override void Draw (Canvas canvas)
		{
			Paint paint = new Paint();

			paint.Alpha = 255;
			canvas.Translate (0, 30);
			paint.Color = global::Android.Graphics.Color.White;
			Path mPath = new Path();
			mPath.AddRoundRect(new RectF(0, 0, 100,100),20,20, Path.Direction.Ccw);
			canvas.ClipPath(mPath, Region.Op.Intersect);
			paint.AntiAlias = true;
			canvas.DrawRect(0, 0, 120,120,paint);
		}
	}
}

