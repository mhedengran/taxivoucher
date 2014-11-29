using System;

namespace TaxiPay
{
	public class Bookings
	{
		public string Id { get; set; }
		public string CreatedAt { get; set; }
		public AddressLocation Pickup { get; set; }
		public AddressLocation Dropoff { get; set; }
		public Payment Payment { get; set; }
	}

	public class AddressLocation
	{
		public string Id { get; set; } = "";
		public string StreetName { get; set; } = "";
		public string HouseNumber { get; set; } = "";
		public string ZipCode { get; set; } = "";
		public string City { get; set; } = "";
		public string Country { get; set; } = "";
		public double Lat { get; set; } = 0;
		public double Lng { get; set; } = 0;
		public string FormattedAddress { get; set; } = "";
	}

	public class Payment
	{
		public string currencySymbol { get; set; }
		public PriceParts PriceParts { get; set; }
	}

	public class PriceParts
	{
		public double Base { get; set; }
		public double Voucher { get; set; }
	}
}

