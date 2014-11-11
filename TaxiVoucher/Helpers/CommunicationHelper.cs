using System;
using System.Net;
using System.IO;
using System.Text;
using RestSharp;
using System.Threading.Tasks;

namespace TaxiVoucher
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
		//GET /places/search (not sure if the right one)

		//start booking

		//status for booking (not sure if used)
		//POST /jobs/:id/statuses

		//update position
		//PUT /bookings/:bookingId/waypoints/:waypointId

		//add voucher to booking
		//POST /vouchers

		//end booking
		//PUT /bookings/:bookingId/complete


		//SETTINGS
		//get bank info

		//change password
		//POST /passwords (get specified what it does)

		//update driver (maybe used)
		//PUT /drivers/:id


		//LOG
		//list of settled bookings
		//GET /payouts

		//list of unsettled bookings
		//GET /bookings/unsettled or GET /drivers/{driverId}/unsettled


		//CREATE USER
		//create user
	}
}

