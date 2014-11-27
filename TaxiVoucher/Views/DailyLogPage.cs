using System;
using Xamarin.Forms;

namespace TaxiPay
{
	public class DailyLogPage : ContentPage
	{
		public DailyLogPage (Driver driver, string date)
		{
			Title = date;

			var viewModel = new DaySummaryViewModel (driver, date);

			var summaryList = new ListView ();
			summaryList.HasUnevenRows = true;
			summaryList.ItemsSource = viewModel.Bookings;

			var cell = new DataTemplate(typeof(SummaryCell));

			summaryList.ItemTemplate = cell;

			Content = summaryList;
		}
	}
}

