using System;
using System.Net;
using System.IO;
using System.Text;
using RestSharp;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Globalization;

namespace TaxiPay
{
	public class CommunicationHelper
	{
		private RestClient client;

		public CommunicationHelper ()
		{
			client = new RestClient ("https://driverapi.staging.drivr.com/");
		}
			
		public Task<JSONResponse> login (string email, string password) {
			var tcs = new TaskCompletionSource<JSONResponse> ();
			String guid = System.Guid.NewGuid ().ToString ();
			guid = guid.Replace ("-", "");

			var request = new RestRequest("sessions/", Method.POST);
			request.AddParameter ("email", email);
			request.AddParameter ("password", password);
			request.AddParameter ("installationIdentifier", String.Format("{0}", guid));
			request.AddParameter ("appVersion", "1.0.0");
			client.ExecuteAsync<JSONResponse> (request, response => {
				tcs.SetResult(response.Data);
				//get specified which types of system messages there is
			});
			return tcs.Task;
		}


		//AUTHENTICATE VOUCHER
		//go online
		//PUT /drivers/:id/online
		public Task<string> PutDriverOnline (Driver driver) {
			var tcs = new TaskCompletionSource<string> ();

			var request = new RestRequest("drivers/{id}/online", Method.PUT);
			request.AddUrlSegment("id", driver.Id);

			request.AddHeader ("Authorization", "Token token=\"" + driver.Token + "\"");

			client.ExecuteAsync<JSONResponse> (request, response => {
				tcs.SetResult(response.Content);
				//get specified which types of system messages there is
			});
			return tcs.Task;
		}

		//get location
		//GET /places/search (finds a address from a coordinate)
		public Task<string> GetAddress (double latitude, double longtitude, string token) {
			var tcs = new TaskCompletionSource<string> ();

			var request = new RestRequest("places/search", Method.GET);
			request.AddParameter ("latlng", latitude + "," + longtitude); 
			request.AddParameter ("radius", 2); 
			request.AddParameter ("query", "jagt");
			
			request.AddHeader ("Authorization", "Token token=\"" + token + "\"");

			client.ExecuteAsync<JSONResponse> (request, response => {
				tcs.SetResult(response.Content);
				//get specified which types of system messages there is
			});
			return tcs.Task;
		}

		//start booking
		public Task<string> StartBooking (double latitude, double longtitude, string token) {
			var tcs = new TaskCompletionSource<string> ();

			var booking = new { pickup = new { lat = latitude, lng = longtitude }};

			var request = new RestRequest("/bookings", Method.POST);

			request.AddParameter("application/json", request.JsonSerializer.Serialize(booking), ParameterType.RequestBody);

			request.AddHeader ("Authorization", "Token token=\"" + token + "\"");
//			request.AddHeader ("X-DEBUG", "C2H5OH");

			client.ExecuteAsync<JSONResponse> (request, response => {
				if (response.Data.Id != null ) {
					tcs.SetResult(response.Data.Id);
				} else {
					tcs.SetResult(response.Content);
				}
			});
			return tcs.Task;
		}

		//update position
		//evenrequest i heartbeat
		//post /events/
		public Task<string> UpdatePostion (double latitude, double longtitude, Driver driver) {
			var tcs = new TaskCompletionSource<string> ();

			var eventRequest = new { 
				eventType = "ping", 
				driverId = driver.Id,
				vehicleId = driver.Vehicle.Id,
				vehiclePositions = new[] { new { lat = latitude, lng = longtitude, vehicleId = driver.Vehicle.Id}}};

			var request = new RestRequest("/events", Method.POST);

			request.AddParameter("application/json", request.JsonSerializer.Serialize(eventRequest), ParameterType.RequestBody);

			request.AddHeader ("Authorization", "Token token=\"" + driver.Token + "\"");
//			request.AddHeader ("X-DEBUG", "C2H5OH");

			client.ExecuteAsync<JSONResponse> (request, response => {
				if (response.Data.Bookings.Count > 0) {
					tcs.SetResult(response.Data.Bookings[0].Id);
				} else {
					tcs.SetResult("");
				}
			});
			return tcs.Task;
		}

		//add voucher to booking
		//POST /vouchers
		public Task<string> ApplyVoucher (Driver driver, string bookingId, string voucherCode) {
			var tcs = new TaskCompletionSource<string> ();

			var parameters = new { bookingId = bookingId, code = voucherCode };

			var request = new RestRequest("/vouchers", Method.POST);
			request.AddParameter("application/json", request.JsonSerializer.Serialize(parameters), ParameterType.RequestBody);

			request.AddHeader ("Authorization", "Token token=\"" + driver.Token + "\"");
//			request.AddHeader ("X-DEBUG", "C2H5OH");

			client.ExecuteAsync<JSONResponse> (request, response => {
				Console.WriteLine(response.Content);
				tcs.SetResult(response.Content);
			});
			return tcs.Task;
		}

		//end booking
		//PUT /bookings/:bookingId/complete
		public Task<JSONResponse> EndBooking (Driver driver, string bookingId, double price) {
			var tcs = new TaskCompletionSource<JSONResponse> ();

			var parameters = new { type = "cash", price = price };

			var request = new RestRequest("/bookings/{id}/complete", Method.PUT);
			request.AddUrlSegment ("id", bookingId);
			request.AddParameter("application/json", request.JsonSerializer.Serialize(parameters), ParameterType.RequestBody);

			request.AddHeader ("Authorization", "Token token=\"" + driver.Token + "\"");
//			request.AddHeader ("X-DEBUG", "C2H5OH");

			client.ExecuteAsync<JSONResponse> (request, response => {
				tcs.SetResult(response.Data);
			});
			return tcs.Task;
		}

		//register payments
		//POST /bookings/:bookingId/payments
		public Task<string> FinishPayments (Driver driver, string bookingId) {
			var tcs = new TaskCompletionSource<string> ();
			var payload = new {};

			var request = new RestRequest("/bookings/{id}/payments", Method.POST);
			request.AddUrlSegment ("id", bookingId);
			request.AddParameter("application/json", request.JsonSerializer.Serialize(payload), ParameterType.RequestBody);

			request.AddHeader ("Authorization", "Token token=\"" + driver.Token + "\"");
//			request.AddHeader ("X-DEBUG", "C2H5OH");

			client.ExecuteAsync<JSONResponse> (request, response => {
				if (response.Data.Id != null ) {
					tcs.SetResult(response.Data.Id);
				} else {
					tcs.SetResult("error");
				}
			});
			return tcs.Task;
		}

		//go offline
		//PUT /drivers/:id/offline
		public Task<string> PutDriverOffline (Driver driver) {
			var tcs = new TaskCompletionSource<string> ();

			var request = new RestRequest("drivers/{id}/offline", Method.PUT);
			request.AddUrlSegment("id", driver.Id);

			request.AddHeader ("Authorization", "Token token=\"" + driver.Token + "\"");

			client.ExecuteAsync<JSONResponse> (request, response => {
				tcs.SetResult(response.Content);
			});
			return tcs.Task;
		}
			

		//SETTINGS
		//update driver
		//PUT /drivers/:id
		public Task<Driver> UpdateDriver (object driver, string Id, string Token) {
			var tcs = new TaskCompletionSource<Driver> ();

			var request = new RestRequest("drivers/{id}", Method.PUT);
			request.AddUrlSegment("id", Id);

			request.AddParameter("application/json", request.JsonSerializer.Serialize(driver), ParameterType.RequestBody);

			request.AddHeader ("Authorization", "Token token=\"" + Token + "\"");
			request.AddHeader ("X-DEBUG", "C2H5OH");

			client.ExecuteAsync<Driver> (request, response => {
				if (response.Data == null) {
					tcs.SetResult(new Driver());
				} else {
					tcs.SetResult(response.Data);
				}
			});
			return tcs.Task;
		}


		//LOG
		//flow
		//1. get week summaries using weeklyEarnings
		//2. get daily summaries from that week using earnings
		//3. get all bookings from that day, using dailybookings

		//GET: /drivers/:id/weeklyEarnings

		//returns a summary of money earned each week
		public Task<string> GetWeeklyEarnings (Driver driver) {
			var tcs = new TaskCompletionSource<string> ();
			var payload = new { limit = 52 };

			var request = new RestRequest("/drivers/{id}/weeklyEarnings", Method.GET);
			request.AddUrlSegment ("id", driver.Id);
			request.AddParameter("application/json", request.JsonSerializer.Serialize(payload), ParameterType.RequestBody);

			request.AddHeader ("Authorization", "Token token=\"" + driver.Token + "\"");
			request.AddHeader ("X-DEBUG", "C2H5OH");

			client.ExecuteAsync<JSONResponse> (request, response => {
				tcs.SetResult(response.Content);
			});
			return tcs.Task;
		}

		//returns 1 week of days, with a summary of each day
//		public Task<string> GetWeeklyEarnings (Driver driver) {
//			var tcs = new TaskCompletionSource<string> ();
//
//			var calender = DateTimeFormatInfo.CurrentInfo.Calendar;
//			DateTime date = new DateTime (2014, 11, 12);
//			var weekNumber = calender.GetWeekOfYear (date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
//			if (weekNumber == 53) {
//				weekNumber = 1;
//			}
//			//			DateTime.UtcNow.ToString()
//
//			var request = new RestRequest("/drivers/{id}/earnings", Method.GET);
//			request.AddUrlSegment ("id", driver.Id);
//			request.AddParameter("weekStartsOn", date.ToString("yyyy-MM-ddTHH:mm:ssZ"));
//
//			request.AddHeader ("Authorization", "Token token=\"" + driver.Token + "\"");
//			request.AddHeader ("X-DEBUG", "C2H5OH");
//
//			client.ExecuteAsync<JSONResponse> (request, response => {
//				tcs.SetResult(response.Content);
//			});
//			return tcs.Task;
//		}

		//returns all bookings on a given day
//		public Task<string> GetWeeklyEarnings (Driver driver) {
//			var tcs = new TaskCompletionSource<string> ();
//
//			var calender = DateTimeFormatInfo.CurrentInfo.Calendar;
//			DateTime date = new DateTime (2014, 11, 17);
//			var weekNumber = calender.GetWeekOfYear (date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
//			if (weekNumber == 53) {
//				weekNumber = 1;
//			}
//			//			DateTime.UtcNow.ToString()
//
//			var request = new RestRequest("/drivers/{id}/dailyBookings", Method.GET);
//			request.AddUrlSegment ("id", driver.Id);
//			request.AddParameter("date", date.ToString("yyyy-MM-ddTHH:mm:ssZ"));
//
//			request.AddHeader ("Authorization", "Token token=\"" + driver.Token + "\"");
//			request.AddHeader ("X-DEBUG", "C2H5OH");
//
//			client.ExecuteAsync<JSONResponse> (request, response => {
//				tcs.SetResult(response.Content);
//			});
//			return tcs.Task;
//		}


		//list of settled bookings
		//use earnings and week earnings (ask peter, as they arent on driverapi.drivr.com

		//list of unsettled bookings
		//same as above


		//CREATE USER
		//create user
	}
}

