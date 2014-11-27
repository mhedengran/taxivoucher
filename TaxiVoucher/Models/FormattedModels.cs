using System;

namespace TaxiPay
{
	public class WeekOrDay
	{
		public string DateString { get; set; }
		public string TotalEarnings { get; set; }
		public string Number { get; set; }
		public string Date { get; set; }
	}

	public class Booking
	{
		public string DateString { get; set; }
		public string TotalEarnings { get; set; }
		public string TotalVoucherEarnings { get; set; }
		public string Number { get; set; }
		public string VoucherNumber { get; set; }
		public string From { get; set; }
		public string To { get; set; }
	}
}

