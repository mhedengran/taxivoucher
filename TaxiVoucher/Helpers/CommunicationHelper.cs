using System;
using System.Net;
using System.IO;
using System.Text;
using RestSharp;
using System.Threading.Tasks;
using System.Collections.Generic;

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
			request.AddParameter ("email", email); //"pt+cph@theill.com"
			request.AddParameter ("password", password); //"123456"
			request.AddParameter ("installationIdentifier", String.Format("{0}", guid));
			request.AddParameter ("appVersion", "1.0.0");
			client.ExecuteAsync<JSONResponse> (request, response => {
				tcs.SetResult(response.Data);
				//get specified which types of system messages there is
			});
			return tcs.Task;
		}

		//AUTHENTICATE VOUCHER
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
		// find out how the status (online/offline/etc..) is handled
		public Task<string> StartBooking (double latitude, double longtitude, string token) {
			var tcs = new TaskCompletionSource<string> ();

			var booking = new { pickup = new { lat = latitude, lng = longtitude }};

			var request = new RestRequest("/bookings", Method.POST);

			request.AddParameter("application/json", request.JsonSerializer.Serialize(booking), ParameterType.RequestBody);

			request.AddHeader ("Authorization", "Token token=\"" + token + "\"");
			request.AddHeader ("X-DEBUG", "C2H5OH");

			client.ExecuteAsync<JSONResponse> (request, response => {
				tcs.SetResult(response.Data.Id);
			});
			return tcs.Task;
		}

		//update position
		//evenrequest i heartbeat
		//post /events/
		public Task<string> UpdatePostion (double latitude, double longtitude, string token) {
			var tcs = new TaskCompletionSource<string> ();

			var booking = new { pickup = new { lat = latitude, lng = longtitude }};

			var request = new RestRequest("/events", Method.POST);

			request.AddParameter("application/json", request.JsonSerializer.Serialize(booking), ParameterType.RequestBody);

			request.AddHeader ("Authorization", "Token token=\"" + token + "\"");
			request.AddHeader ("X-DEBUG", "C2H5OH");

			client.ExecuteAsync<JSONResponse> (request, response => {
				tcs.SetResult(response.Content);
			});
			return tcs.Task;
		}

		//add voucher to booking
		//POST /vouchers

		//end booking
		//PUT /bookings/:bookingId/complete


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

