using System;
using Xamarin.Forms;

namespace TaxiVoucher
{
	public class RedeemVoucherView : ContentPage
	{
		Entry priceEntry;
		Entry voucherCodeEntry;
		Entry streetEntry;
		Entry numberEntry;
		Entry zipCodeEntry;
		Entry cityEntry;

		public RedeemVoucherView ()
		{
			Title = "Indløs";

			Button finishTripButton = new Button {
				Text = "Afslut tur",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.End
			};
			finishTripButton.Clicked += OnFinishTripClicked;

			voucherCodeEntry = new Entry {
				Keyboard = Keyboard.Text,
				Placeholder = "Bon nummer",
				VerticalOptions = LayoutOptions.Start
			};

			priceEntry = new Entry {
				Keyboard = Keyboard.Numeric,
				Placeholder = "Pris",
				VerticalOptions = LayoutOptions.Start
			};

			streetEntry = new Entry {
				Keyboard = Keyboard.Text,
				Placeholder = "Vej",
				VerticalOptions = LayoutOptions.End,
			};

			numberEntry = new Entry {
				Keyboard = Keyboard.Numeric,
				Placeholder = "Nr",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start
			};

			zipCodeEntry = new Entry {
				Keyboard = Keyboard.Numeric,
				Placeholder = "Postnummer",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};

			cityEntry = new Entry {
				Keyboard = Keyboard.Text,
				Placeholder = "By",
				VerticalOptions = LayoutOptions.End,
			};

			StackLayout horizontalStacklayout = new StackLayout
			{
				Spacing = 10,
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children =
				{
					numberEntry,
					zipCodeEntry
				}
			};

			StackLayout innerStacklayout = new StackLayout
			{
				Spacing = 10,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(20, 100, 20, 10),
				Children = 
				{
					voucherCodeEntry,
					priceEntry,

					new Label
					{
						Text = "Start adresse",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.EndAndExpand
					},
					streetEntry,
					horizontalStacklayout,
					cityEntry
				}
			};

			StackLayout outerStacklayout = new StackLayout {
				Spacing = 10,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = 
				{
					innerStacklayout,
					finishTripButton
				}
			};
			Content = outerStacklayout;
		}

		void OnFinishTripClicked(object sender, EventArgs e) 
		{
			Console.WriteLine ("finish trip");
		}
	}
}

