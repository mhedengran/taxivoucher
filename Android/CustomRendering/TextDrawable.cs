using System;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

namespace TaxiPay.Android
{
	public class TextDrawable : Drawable {

		private readonly String text;
		private readonly Paint paint;

		public TextDrawable(String text) {

			this.text = text;

			Typeface font = Typeface.CreateFromAsset (Forms.Context.Assets, "FontAwesome.otf");
			this.paint = new Paint();
			paint.Color = global::Android.Graphics.Color.ParseColor(Colors.textColor);
			paint.TextSize = 50;
			paint.AntiAlias = true;
//			paint.FakeBoldText = true;
//			paint.SetShadowLayer(6f, 0, 0, global::Android.Graphics.Color.Black);
			paint.SetStyle(Paint.Style.Fill);
			paint.TextAlign = Paint.Align.Center;
			paint.SetTypeface (font);

		}
			
		public override void Draw(Canvas canvas) {
			canvas.DrawText(text, 0, 0, paint);
		}
			
		public override void SetAlpha(int alpha) {
			paint.Alpha = alpha;
		}
			
		public override void SetColorFilter(ColorFilter cf) {
			paint.SetColorFilter(cf);
		}
			
		public override int Opacity {
			get { return 1; }
		}
	}
}

