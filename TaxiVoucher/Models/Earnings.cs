using System;
using System.Collections.Generic;

namespace TaxiPay
{
	public class JSONWrapper 
	{
		public List<WeeklyEarnings> Data { get; set; }
		public string After { get; set; }
	}

	public class WeeklyEarnings
	{
		public string EarningsOn {get;set;}
		public double Amount { get; set; }
		public string Currency { get; set; }
		public string CurrencySymbol { get; set; }
	}

	public class DailyEarnings
	{
		public string EarningsOn { get; set; }
		public int CashBookings { get; set; }
		public int CardBookings { get; set; }
		public double CashAmount { get; set; }
		public double CardAmount  { get; set; }
		public string Currency { get; set; }
		public string CurrencySymbol { get; set; }
		public double Duration { get; set; }
	}
}

