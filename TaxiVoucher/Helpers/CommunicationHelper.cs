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

		public async Task<Driver> login (string email, string password) {

			String guid = System.Guid.NewGuid ().ToString ();
			guid = guid.Replace ("-", "");

			var request = new RestRequest("sessions/", Method.POST);
			request.AddParameter ("email", email); //"pt+cph@theill.com"
			request.AddParameter ("password", password); //"123456"
			request.AddParameter ("installationIdentifier", String.Format("{0}", guid));
			request.AddParameter ("appVersion", "1.0.0");
//			Task<JSONResponse> responseTask = client.ExecuteAsync<JSONResponse> (request, response => {
//
//			});
			tempResponse = await responseTask;
			return tempResponse.Driver;
		}
	}
}

