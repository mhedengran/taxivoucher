using System;
using Xamarin.Forms;

namespace TaxiPay
{
	public class DailyLogPage : ContentPage
	{
		public DailyLogPage (Driver driver, string date, string totalEarnings)
		{
			Title = Convert.ToDateTime(date).ToString("MM/dd-yyyy");
			BackgroundColor = Color.FromHex (Colors.backgroundColor);

			var viewModel = new DaySummaryViewModel (driver, date);

			var summaryList = new ListView ();
			summaryList.BackgroundColor = Color.FromHex (Colors.backgroundColor);
			summaryList.HasUnevenRows = true;
			summaryList.ItemsSource = viewModel.Bookings;

			var cell = new DataTemplate(typeof(SummaryCell));

			summaryList.ItemTemplate = cell;

			StackLayout layout = new StackLayout {
				Padding = new Thickness(0, 5, 0, 0),
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = {
					new Label {
						HorizontalOptions = LayoutOptions.CenterAndExpand,
						VerticalOptions = LayoutOptions.Center,
						Text = "Ialt " + viewModel.Bookings.Count + " ture til " + totalEarnings,
						TextColor = Color.FromHex (Colors.textColor),
						Font = Font.SystemFontOfSize(20)
					},
					summaryList

				}
			};

			Content = layout;
		}
	}
}

