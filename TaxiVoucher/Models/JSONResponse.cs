using System;
using System.Collections.Generic;

namespace TaxiPay
{
	public class JSONResponse
	{
		public Driver Driver { get; set;}
		public string SystemMessage { get; set;}
		public string Token { get; set;}
		public string Id { get; set; }
		public List<Bookings> Bookings { get; set; }
		public Payment Payment { get; set; }
	}
}

