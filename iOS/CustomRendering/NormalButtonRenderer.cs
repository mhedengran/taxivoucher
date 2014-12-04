using System;
using System.Collections.Generic;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using TaxiPay;
using TaxiPay.iOS;
using System.Drawing;

[assembly: ExportRenderer (typeof (NormalButton), typeof (NormalButtonRenderer))]
namespace TaxiPay.iOS
{
	public class NormalButtonRenderer : ButtonRenderer
	{
		public override void Draw (RectangleF rect) {
			base.Draw (rect); 
			int inset = 10;
			var nativeButton = (UIButton)Control;
			var button = (NormalButton)this.Element;
			int height = (int)button.HeightRequest;
			if (height <= 0) {
				height = (int)rect.Height;
			}
			int width = (int)button.WidthRequest;
			if (width <= 0) {
				width = (int)rect.Width;
			}
			//common looks
			nativeButton.Layer.CornerRadius = 15;
			nativeButton.ClipsToBounds = true;

			button.Font = Font.SystemFontOfSize (Math.Max (height / 3, 16));

			NSString arrowString = (NSString)IconStrings.arrowRightIcon;
			UIStringAttributes attributes = new UIStringAttributes {
				Font = UIFont.SystemFontOfSize (Math.Max(height / 2, 16))
			};
			SizeF sizeOfString = arrowString.GetSizeUsingAttributes (attributes);
			UILabel icon;
			if (button.ArrowPositionRight) {
				icon = new UILabel (new RectangleF (width-inset-sizeOfString.Width, 0, sizeOfString.Width, height));
				//move position to right side of label
				icon.Text = IconStrings.arrowRightIcon;
			} else {
				icon = new UILabel (new RectangleF (inset, 0, sizeOfString.Width, height));
				icon.Text = IconStrings.arrowLeftIcon;
			}
			icon.Font = UIFont.FromName ("FontAwesome", Math.Max (height / 2, 16));
			icon.TextColor = UIColor.FromRGB (0x44, 0x44, 0x44);
			icon.TextAlignment = UITextAlignment.Center;

			nativeButton.AddSubview (icon);
			nativeButton.BringSubviewToFront (icon);

			//non pushed
			nativeButton.BackgroundColor = UIColor.FromRGB (0x85, 0xA3, 0xB8);
			nativeButton.SetTitleColor (UIColor.FromRGB (0x44, 0x44, 0x44), UIControlState.Normal);

			//pushed
		}
	}
}

