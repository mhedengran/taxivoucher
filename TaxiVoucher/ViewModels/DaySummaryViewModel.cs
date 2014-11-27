using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TaxiPay
{
	public class DaySummaryViewModel
	{
		public ObservableCollection<Booking> Bookings { get; set; }

		public DaySummaryViewModel (Driver driver, string date)
		{
			
			var getDailyEarningsTask = new CommunicationHelper ().GetDailyEarnings (driver, date);
			List<Bookings> bookingList = getDailyEarningsTask.Result;
			//daily

			Bookings = new ObservableCollection<Booking> ();
			foreach (Bookings item in bookingList) {
				//Mangler currency
				if (item.Payment != null && item.Dropoff != null && item.Pickup != null) {
					Bookings.Add (new Booking {
						DateString = Convert.ToDateTime(item.CreatedAt).ToString("MM/dd-yyyy"),
						TotalEarnings = "Pris",
						TotalVoucherEarnings = "Værdi",
						Number = item.Payment.PriceParts.Base + " " + item.Payment.currencySymbol,
						VoucherNumber = item.Payment.PriceParts.Voucher + " " + item.Payment.currencySymbol,
						From = item.Pickup.FormattedAddress,
						To = item.Dropoff.FormattedAddress
					});
				}
			}
		}
	}
}

