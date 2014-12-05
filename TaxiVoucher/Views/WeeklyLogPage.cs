using System;
using Xamarin.Forms;

namespace TaxiPay
{
	public class WeeklyLogPage : ContentPage
	{
		public WeeklyLogPage (Driver driver, WeekOrDay week)
		{
			Title = week.DateString;
			BackgroundColor = Color.FromHex (Colors.backgroundColor);

			var viewModel = new DayListViewModel (driver, week.Date);

			var dayList = new ListView ();
			dayList.BackgroundColor = Color.FromHex (Colors.backgroundColor);
			dayList.ItemsSource = viewModel.Days;

			var cell = new DataTemplate(typeof(WeekOrDayCell));

			dayList.ItemTemplate = cell;

			dayList.ItemTapped += (sender, args) =>
			{
				var day = args.Item as WeekOrDay;
				if (day == null) {
					return;
				} else {
					dayList.SelectedItem = null;
					Navigation.PushAsync(new DailyLogPage(driver, day.Date, day.Number));
				}
			};

			Content = dayList;
		}
	}
}

