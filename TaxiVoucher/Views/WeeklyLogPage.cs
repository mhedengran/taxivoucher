using System;
using Xamarin.Forms;

namespace TaxiPay
{
	public class WeeklyLogPage : ContentPage
	{
		public WeeklyLogPage (Driver driver, WeekOrDay week)
		{
			Title = week.DateString;

			var viewModel = new DayListViewModel (driver, week.Date);

			var dayList = new ListView ();
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
					Navigation.PushAsync(new DailyLogPage(driver, day.Date));
				}
			};

			Content = dayList;
		}
	}
}

