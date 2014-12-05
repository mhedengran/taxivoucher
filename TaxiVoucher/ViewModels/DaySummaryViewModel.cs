using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

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
			int i = 0;
			Bookings = new ObservableCollection<Booking> ();
			foreach (Bookings item in bookingList) {
				//Mangler currency
				if (item.Payment != null && item.Dropoff != null && item.Pickup != null) {
					Color background;
					if (i == 0) {
						background = Color.White;
						i++;
					} else {
						background = Color.Transparent;
						i = 0;
					}
					Bookings.Add (new Booking {
						BackgroundColor = background,
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

