using System;
using Xamarin.Forms;

namespace TaxiPay
{
	public class VoucherReceiptPage : ContentPage
	{
		public VoucherReceiptPage (double voucherValue, double tripPrice)
		{
			StackLayout stacklayout = new StackLayout
			{
				Spacing = 10,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(20, 100, 20, 10),
				Children = 
				{
					new Label
					{
						Text = "Bon værdi " + voucherValue + "kr",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center
					},

					new Label
					{
						Text = "Pris for tur " + tripPrice + "kr",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center
					},

					new Label
					{
						Text = "Modtag kontant: " + (tripPrice-voucherValue) + "kr",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions. Center
					},
				}
			};
			Content = stacklayout;
		}
	}
}

