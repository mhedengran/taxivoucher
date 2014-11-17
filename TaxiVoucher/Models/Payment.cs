using System;
using System.Collections.Generic;

namespace TaxiPay
{
	public class Payment
	{
		public Receipt Receipt { get; set; }
	}

	public class Receipt
	{
		public double Price { get; set; }
		public List<Voucher> Vouchers { get; set; }

	}

	public class Voucher
	{
		public double Value { get; set; }
	}
}

