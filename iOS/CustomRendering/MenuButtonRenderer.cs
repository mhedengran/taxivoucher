using System;
using System.Collections.Generic;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.CoreGraphics;
using TaxiPay;
using TaxiPay.iOS;
using System.Drawing;

[assembly: ExportRenderer (typeof (MenuButton), typeof (MenuButtonRenderer))]
namespace TaxiPay.iOS
{
	public class MenuButtonRenderer : ButtonRenderer
	{
		public override void Draw (RectangleF rect) {
			base.Draw (rect);
			int inset = 15;
			int spacing = 10;
			var nativeButton = (UIButton) Control;
			var button = (MenuButton)this.Element;
			int height = (int)button.HeightRequest;
			if (height <= 0) {
				height = (int)rect.Height;
			}
			int fontSize = Math.Max (height / 3, 16);
			//common looks
			nativeButton.Layer.CornerRadius = 15;
			nativeButton.ClipsToBounds = true;

			Console.WriteLine( base.GetConstraintsAffectingLayout (UILayoutConstraintAxis.Horizontal).ToString());
			//find the width of the button
			if (button.Icon.Length > 0) {
				UILabel icon = new UILabel (new RectangleF (inset, 0, height, height));
				icon.Font = UIFont.FromName ("FontAwesome", Math.Max(height/2, 16));
				icon.Text = button.Icon;
				icon.TextColor = UIColor.White;
				icon.TextAlignment = UITextAlignment.Center;
				nativeButton.AddSubview (icon);
				UILabel text = new UILabel (new RectangleF (icon.Frame.Location.X + icon.Frame.Size.Width + spacing, 0, rect.Width-(icon.Frame.Size.Width+icon.Frame.Location.X)-10/*sizeOfString.Width*/, height));
				text.Text = button.LabelText;
				text.TextAlignment = UITextAlignment.Left;
				text.TextColor = UIColor.White;
				text.Font = UIFont.SystemFontOfSize (fontSize);
				nativeButton.AddSubview (text);
			} else {
				button.Text = button.LabelText;
				button.Font = Font.SystemFontOfSize (fontSize);
				button.TextColor = Color.White;
			}

			RectangleF colorRect = new RectangleF(0.0f, 0.0f, 1.0f, 1.0f);
			UIGraphics.BeginImageContext(colorRect.Size);
			CGContext context = UIGraphics.GetCurrentContext ();

			context.SetFillColorWithColor (UIColor.FromRGB (0xEE, 0xEE, 0xEE).CGColor);
			context.FillRect(colorRect);

			UIImage image = UIGraphics.GetImageFromCurrentImageContext();
			UIGraphics.EndImageContext ();
			nativeButton.SetBackgroundImage (image, UIControlState.Highlighted);
			nativeButton.BackgroundColor = UIColor.FromRGB(0x55, 0x55, 0x55);
		}
	}
}

