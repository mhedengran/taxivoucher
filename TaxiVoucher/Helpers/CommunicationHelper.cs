using System;
using System.Net;
using System.IO;
using System.Text;
using RestSharp;
using System.Threading.Tasks;

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
			request.AddHeader ("X-DEBUG", "C2H5OH");

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
				vehicleId = driver.vehicle.Id,
				vehiclePositions = new[] { new { lat = latitude, lng = longtitude, vehicleId = driver.vehicle.Id}}};

			var request = new RestRequest("/events", Method.POST);

			request.AddParameter("application/json", request.JsonSerializer.Serialize(eventRequest), ParameterType.RequestBody);

			request.AddHeader ("Authorization", "Token token=\"" + driver.Token + "\"");
			request.AddHeader ("X-DEBUG", "C2H5OH");

			client.ExecuteAsync<JSONResponse> (request, response => {
				Console.WriteLine("test");
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
			request.AddHeader ("X-DEBUG", "C2H5OH");

			client.ExecuteAsync<JSONResponse> (request, response => {
				Console.WriteLine(response.Content);
				tcs.SetResult(response.Content);
			});
			return tcs.Task;
		}

		//end booking
		//PUT /bookings/:bookingId/complete
		public Task<string> EndBooking (Driver driver, string bookingId, double price) {
			var tcs = new TaskCompletionSource<string> ();

			var parameters = new { type = "cash", price = price };

			var request = new RestRequest("/bookings/{id}/complete", Method.PUT);
			request.AddUrlSegment ("id", bookingId);
			request.AddParameter("application/json", request.JsonSerializer.Serialize(parameters), ParameterType.RequestBody);

			request.AddHeader ("Authorization", "Token token=\"" + driver.Token + "\"");
			request.AddHeader ("X-DEBUG", "C2H5OH");

			client.ExecuteAsync<JSONResponse> (request, response => {
				if (response.Data.Id != null ) {
					tcs.SetResult(response.Data.Id);
				} else {
					tcs.SetResult("error");
				}
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
			request.AddHeader ("X-DEBUG", "C2H5OH");

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
		//get bank info
		//SET: //PUT /drivers/:id
		//GET: //

		//change password
		//POST /passwords (get specified what it does)

		//update driver (maybe used)
		//PUT /drivers/:id


		//LOG
		//list of settled bookings
		//use earnings and week earnings (ask peter, as they arent on driverapi.drivr.com

		//list of unsettled bookings
		//same as above


		//CREATE USER
		//create user
	}
}

