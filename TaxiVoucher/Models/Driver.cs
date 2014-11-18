using System;

namespace TaxiPay
{
	public class Driver
	{
		public string Id { get; set; } = "";

		public string Email { get; set; } = "";
		public string ExternalReference { get ; set; } = "";

		public string FirstName { get; set; } = "";
		public string LastName { get; set; } = "";

		public string Token { get; set;} = "";

		public Vehicle Vehicle { get; set; } 

		public BankAccount BankAccount { get; set; } = new BankAccount();
	}

	public class Vehicle
	{
		public string Id { get; set; } = "";
	}

	public class BankAccount
	{
		public string Swift { get; set; } = "";
		public string Iban { get; set; } = "";
		public string AccountHolderName { get; set; } = "";
	}
}

