using System;
using System.Globalization;
using Xamarin.Forms;

namespace TaxiPay
{
	public class LogPage : ContentPage
	{
		public LogPage ()
		{
			Title = "Log";

			//used for finding correct week move to viewmodel
			var calender = DateTimeFormatInfo.CurrentInfo.Calendar;
			DateTime date = new DateTime (2015, 01, 05);
			var weekNumber = calender.GetWeekOfYear (date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
			if (weekNumber == 53) {
				weekNumber = 1;
			}


			Button unsettledButton = new Button {
				Text = "Unsetteled trips",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.Start
			};
			unsettledButton.Clicked += OnUnsettledClicked;

			//define some data, use viewmodel

			var weekView = new ListView {
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.StartAndExpand
			};
//			weekView.ItemsSource = list of data

			var cell = new DataTemplate(typeof(TextCell));
			cell.SetBinding (TextCell.TextProperty, "weekName");

			weekView.ItemTemplate = cell;

			weekView.ItemTapped += onListItemTapped;

			StackLayout stacklayout = new StackLayout
			{
				Spacing = 0,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(0, 0, 0, 0),
				Children = 
				{
					unsettledButton,
					weekView
				}
			};

			Content = stacklayout;
		}

		void OnUnsettledClicked(object sender, EventArgs e) {
			Console.WriteLine ("unsettled");
		}

		void onListItemTapped(object sender, EventArgs e) {
			Console.WriteLine ("listbutton");
//			var monkey = args.Item as Monkey;
//			if (monkey == null)
//				return;
//			Navigation.PushAsync(new DetailsPage(monkey));
//			list.SelectedItem = null;
		}
	}
}

