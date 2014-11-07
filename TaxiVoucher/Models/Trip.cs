using System;

namespace TaxiVoucher
{
	namespace TaxiVoucher
	{
		public class Trip
		{
			public string Id {get;set;}
			public string Date { get; set; }
			public double Price { get; set; }
			public string FromStreet { get; set; }
			public string FromNumber { get; set; }
			public string FromZipCode { get; set; }
			public string FromTown { get; set; }
			public string ToStreet { get; set; }
			public string ToNumber { get; set; }
			public string ToZipCode { get; set; }
			public string ToTown { get; set; }
		}
	}
}

