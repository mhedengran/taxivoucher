using System;
using Xamarin.Forms;

namespace TaxiPay
{
	public class TotalLogPage : ContentPage
	{
		public TotalLogPage (Driver driver)
		{
			Title = "Log";
			BackgroundColor = Color.FromHex (Colors.backgroundColor);

			var viewModel = new WeekListViewModel (driver);

			//define some data, use viewmodel

			var weekList = new ListView ();
			weekList.BackgroundColor = Color.FromHex (Colors.backgroundColor);
			weekList.ItemsSource = viewModel.Weeks;

			var cell = new DataTemplate(typeof(WeekOrDayCell));

			weekList.ItemTemplate = cell;

			weekList.ItemTapped += async (sender, args) =>
			{
				var week = args.Item as WeekOrDay;
				if (week == null) {
					return;
				} else {
					weekList.SelectedItem = null;
					await Navigation.PushAsync(new WeeklyLogPage(driver, week));
				}
			};

			Content = weekList;
		}
	}
}

