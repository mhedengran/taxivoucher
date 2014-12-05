using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using Xamarin.Forms;

namespace TaxiPay
{
	public class WeekListViewModel
	{
		public ObservableCollection<WeekOrDay> Weeks { get; set; }

		public WeekListViewModel (Driver driver)
		{
			//weekly
			var getTotalEarningsTask = new CommunicationHelper ().GetTotalEarnings (driver);
			List<WeeklyEarnings> WeekList = getTotalEarningsTask.Result;
			int i = 0;
			Weeks = new ObservableCollection<WeekOrDay> ();
			foreach (WeeklyEarnings item in WeekList) {
				Color background;
				if (i == 0) {
					background = Color.White;
					i++;
				} else {
					background = Color.Transparent;
					i = 0;
				}
				Weeks.Add (new WeekOrDay 
					{
						BackgroundColor = background,
						DateString = "Uge " + GetWeekNumberFromDate(item.EarningsOn),
						TotalEarnings = "Totalt beløb",
						Number = item.Amount + " " + item.CurrencySymbol,
						Date = item.EarningsOn
					});
			}
		}

		private int GetWeekNumberFromDate (string date) 
		{
			var calender = DateTimeFormatInfo.CurrentInfo.Calendar;
			DateTime newDate = Convert.ToDateTime (date); /*.ToString("yyyy-MM-ddTHH:mm:ssZ")*/
			var weekNumber = calender.GetWeekOfYear (newDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
			if (weekNumber == 53) {
				weekNumber = 1;
			}
			return weekNumber;
		}
	}
}

