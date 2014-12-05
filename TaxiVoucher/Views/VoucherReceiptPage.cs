using System;
using Xamarin.Forms;

namespace TaxiPay
{
	public class VoucherReceiptPage : ContentPage
	{
		public VoucherReceiptPage (double voucherValue, double tripPrice)
		{
			Title = "Kvittering";
			BackgroundColor = Color.FromHex (Colors.backgroundColor);
//			NormalButton button = new NormalButton {
//				Text = "Tilbage til menu",
//				ArrowPositionRight = false,
//				HorizontalOptions = LayoutOptions.FillAndExpand,
//				VerticalOptions = LayoutOptions.EndAndExpand,
//				HeightRequest = 40,
//			};
//			Button.Clicked += OnButtonClicked;
			StackLayout stacklayout = new StackLayout
			{
				Spacing = 20,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(30, 70, 30, 30),

				Children = 
				{
					new RoundedFrame {
						BackgroundColor = Color.White,
						OutlineColor = Color.Transparent,
						HasShadow = false,
						Padding = 0,
						Content = new StackLayout {
							Padding = new Thickness(0, 10, 0, 80),
							VerticalOptions = LayoutOptions.StartAndExpand,
							Spacing = 20,
							Children = {
								new Label
								{
									Text = "Kvittering for tur",
									TextColor = Color.FromHex(Colors.textColor),
									Font = Font.SystemFontOfSize(20),
									HorizontalOptions = LayoutOptions.CenterAndExpand,
									VerticalOptions = LayoutOptions.Start
								},

								new StackLayout {
									Padding = new Thickness(20, 20, 20, 0),
									VerticalOptions = LayoutOptions.CenterAndExpand,
									HorizontalOptions = LayoutOptions.FillAndExpand,
									Orientation = StackOrientation.Horizontal,
									Children = {
										new Label
										{
											Text = "Pris",
											TextColor = Color.FromHex(Colors.textColor),
											Font = Font.SystemFontOfSize(16),
											HorizontalOptions = LayoutOptions.StartAndExpand,
											VerticalOptions = LayoutOptions.Center
										},
										new Label
										{
											Text = tripPrice + " kr",
											TextColor = Color.FromHex(Colors.textColor),
											Font = Font.SystemFontOfSize(16),
											HorizontalOptions = LayoutOptions.End,
											VerticalOptions = LayoutOptions.Center
										},
									}
								},

								new StackLayout {
									Padding = new Thickness(20, 0, 20, 0),
									VerticalOptions = LayoutOptions.CenterAndExpand,
									HorizontalOptions = LayoutOptions.FillAndExpand,
									Orientation = StackOrientation.Horizontal,
									Children = {
										new Label
										{
											Text = "Bon værdi",
											TextColor = Color.FromHex(Colors.textColor),
											Font = Font.SystemFontOfSize(16),
											HorizontalOptions = LayoutOptions.StartAndExpand,
											VerticalOptions = LayoutOptions.Center
										},
										new Label
										{
											Text =  voucherValue + " kr",
											TextColor = Color.FromHex(Colors.textColor),
											Font = Font.SystemFontOfSize(16),
											HorizontalOptions = LayoutOptions.End,
											VerticalOptions = LayoutOptions.Center
										},
									}
								},

								new StackLayout {
									Padding = new Thickness(20, 20, 20, 0),
									VerticalOptions = LayoutOptions.CenterAndExpand,
									HorizontalOptions = LayoutOptions.FillAndExpand,
									Orientation = StackOrientation.Horizontal,
									Children = {
										new Label
										{
											Text = "Betal i vogn",
											TextColor = Color.FromHex(Colors.textColor),
											Font = Font.SystemFontOfSize(16),
											HorizontalOptions = LayoutOptions.StartAndExpand,
											VerticalOptions = LayoutOptions. Center
										},
										new Label
										{
											Text =  (tripPrice-voucherValue) + " kr",
											TextColor = Color.FromHex(Colors.textColor),
											Font = Font.SystemFontOfSize(16),
											HorizontalOptions = LayoutOptions.End,
											VerticalOptions = LayoutOptions.Center
										},
									}
								},
							}
						},
					}
//					button
				}
			};
			Content = stacklayout;
		}

//		async void OnButtonClicked(object sender, EventArgs e) {
//			Navigation.PopAsync ();
//		}
	}
}

