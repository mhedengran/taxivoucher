using System;
using System.Collections.Generic;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using TaxiPay;
using TaxiPay.iOS;
using System.Drawing;

[assembly: ExportRenderer (typeof (MenuButton), typeof (MenuButtonRenderer))]
namespace TaxiPay.iOS
{
	public class MenuButtonRenderer : ButtonRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged (e);
			if (e.OldElement == null) { 
				int inset = 15;
				int spacing = 10;
				var nativeButton = (UIButton) Control;
				var button = (MenuButton)this.Element;
				int height = (int)button.HeightRequest;
				int fontSize = Math.Max (height / 3, 16);
				//common looks
				nativeButton.Layer.CornerRadius = 10;
				nativeButton.ClipsToBounds = true;

				//find the width of the button
				if (button.Icon.Length > 0) {
					UILabel icon = new UILabel (new RectangleF (inset, 0, height, height));
					icon.Font = UIFont.FromName ("FontAwesome", Math.Max(height/2, 16));
					icon.Text = button.Icon;
					icon.TextColor = UIColor.White;
					icon.TextAlignment = UITextAlignment.Center;
					nativeButton.AddSubview (icon);
					NSString labelString = (NSString)button.LabelText;
					UIStringAttributes attributes = new UIStringAttributes {
						Font = UIFont.SystemFontOfSize (fontSize)
					};
					SizeF sizeOfString = labelString.GetSizeUsingAttributes (attributes);
					UILabel text = new UILabel (new RectangleF (icon.Frame.Location.X + icon.Frame.Size.Width + spacing, 0, sizeOfString.Width, height));
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
					
				nativeButton.BackgroundColor = UIColor.FromRGB(0x55, 0x55, 0x55);
				nativeButton.SetTitleColor (UIColor.White, UIControlState.Normal);
			}
		}
	}
}

