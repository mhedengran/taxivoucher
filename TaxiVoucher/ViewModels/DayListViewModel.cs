using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace TaxiPay
{
	public class DayListViewModel
	{
		public ObservableCollection<WeekOrDay> Days { get; set; }

		public DayListViewModel (Driver driver, string date)
		{
			//daily
			var getWeeklyEarningsTask = new CommunicationHelper ().GetWeeklyEarnings (driver, date);
			List<DailyEarnings> dayList = getWeeklyEarningsTask.Result;

			Days = new ObservableCollection<WeekOrDay> ();
			foreach (DailyEarnings item in dayList) {
				Days.Add (new WeekOrDay 
					{
						DateString = GetDayOfWeek(item.EarningsOn),
						TotalEarnings = "Totalt beløb",
						Number = item.CashAmount + " " + item.CurrencySymbol,
						Date = item.EarningsOn
					});
			}
		}

		public string GetDayOfWeek (string date) {
			DateTime newDate = Convert.ToDateTime (date);
			switch (newDate.DayOfWeek.ToString ()) {
			case "Monday":
				return "Mandag";
			case "Tuesday":
				return "Tirsdag";
			case "Wednesday":
				return "Onsdag";
			case "Thursday":
				return "Torsdag";
			case "Friday":
				return "Fredag";
			case "Saturday":
				return "Lørdag";
			default:
				return "Søndag";
			}
		}

	}
}

