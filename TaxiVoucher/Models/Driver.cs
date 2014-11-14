using System;

namespace TaxiPay
{
	public class Driver
	{
		public string Id { get; set; } = "";

		public string Email { get; set; } = "";
		public string DriverNumber { get; set; } = "";

		public string FirstName { get; set; } = "";
		public string LastName { get; set; } = "";

		public string Iban { get; set; } = "";
		public string Swift { get; set; } = "";

		public string Token { get; set;} = "";

		public Vehicle vehicle { get; set; } 
	}
}

