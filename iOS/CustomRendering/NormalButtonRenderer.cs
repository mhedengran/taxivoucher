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
		protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged (e);
			if (e.OldElement == null) { 
				int inset = 10;
				var nativeButton = (UIButton)Control;
				var button = (NormalButton)this.Element;
				int height = (int)button.HeightRequest;
				int width = (int)button.WidthRequest;
				//common looks
				nativeButton.Layer.CornerRadius = 10;
				nativeButton.ClipsToBounds = true;

				button.Font = Font.SystemFontOfSize (Math.Max (height / 3, 16));

				NSString arrowString = (NSString)IconStrings.arrowRightIcon;
				UIStringAttributes attributes = new UIStringAttributes {
					Font = UIFont.SystemFontOfSize (Math.Max(height / 2, 16))
				};
				SizeF sizeOfString = arrowString.GetSizeUsingAttributes (attributes);
				UILabel icon = new UILabel (new RectangleF (inset, 0, sizeOfString.Width, height));
				icon.Font = UIFont.FromName ("FontAwesome", Math.Max (height / 2, 16));
				icon.TextColor = UIColor.FromRGB (0x44, 0x44, 0x44);
				icon.TextAlignment = UITextAlignment.Center;

				//find the width of the button
				if (button.ArrowPositionRight) {
					//move position to right side of label
					icon.Text = IconStrings.arrowRightIcon;
				} else {
					icon.Text = IconStrings.arrowLeftIcon;
				}

				nativeButton.AddSubview (icon);
				nativeButton.BringSubviewToFront (icon);

				//non pushed
				nativeButton.BackgroundColor = UIColor.FromRGB (0x85, 0xA3, 0xB8);
				nativeButton.SetTitleColor (UIColor.FromRGB (0x44, 0x44, 0x44), UIControlState.Normal);

				//pushed
			}
		}
	}
}

