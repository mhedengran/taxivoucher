using System;
using System.Collections.Generic;

namespace TaxiPay
{
	public class Events
	{
		public string driverStatus { get; set; }
		public string driverInstallationIdentifier { get; set; }
		public string driverState { get; set; }
		public string createdAt { get; set; }
		public string vehicleId { get; set; }
		public List<Bookings> bookings { get; set; }
	}
}

