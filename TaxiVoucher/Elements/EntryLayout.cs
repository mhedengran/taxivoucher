using System;
using Xamarin.Forms;

namespace TaxiPay
{
	public class EntryLayout
	{
		public TextEntry TextEntry { get; set;}

		public StackLayout GetTextEntryLayout (string placeHolder, Keyboard keyboardType, bool isPassword) {

			TextEntry = new TextEntry {
				Text = "",
				Keyboard = keyboardType,
				Placeholder = placeHolder,
				IsPassword = isPassword,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				HeightRequest = 42
			};
			StackLayout layout;
			if (Device.OS == TargetPlatform.iOS) {
				BoxView filler = new BoxView {
					BackgroundColor = Color.White,
					HorizontalOptions = LayoutOptions.Start,
					HeightRequest = 40,
					WidthRequest = 10
				};
				layout = new StackLayout {
					Spacing = 0,
					HorizontalOptions = LayoutOptions.FillAndExpand,
					Orientation = StackOrientation.Horizontal,
					Children = { filler, TextEntry }
				};
			} else {
				layout = new StackLayout {
					Spacing = 0,
					HorizontalOptions = LayoutOptions.FillAndExpand,
					Orientation = StackOrientation.Horizontal,
					Children = { TextEntry }
				};
			}
			return layout;
		}

		public StackLayout GetLayoutWithIcon (string placeHolder, Keyboard keyboardType, string icon, bool isPassword) {
			StackLayout textEntry = GetTextEntryLayout (placeHolder, keyboardType, isPassword);

			Label label = new IconLabel {
				Text = icon,
				Font = Device.OnPlatform(
					Font.OfSize ("FontAwesome", 24),
					Font.SystemFontOfSize (24),
					Font.SystemFontOfSize (24)
				),
				TextColor = Color.White,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			StackLayout box = new StackLayout {
				BackgroundColor = Color.FromHex("555555"),
				HorizontalOptions = LayoutOptions.Start,
				HeightRequest = 40,
				WidthRequest = 40,
				Children = { label }
			};
					
			StackLayout layout = new StackLayout {
				Spacing = 0,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Orientation = StackOrientation.Horizontal,
				Children = { box, textEntry }
			};

			return layout;
		}
	}
}

