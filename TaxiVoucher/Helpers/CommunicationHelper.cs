using System;
using System.Net;
using System.IO;
using System.Text;
using RestSharp;

namespace TaxiVoucher
{
	public class CommunicationHelper
	{
		public CommunicationHelper ()
		{
			//for testing
			String guid = System.Guid.NewGuid ().ToString ();
			guid = guid.Replace ("-", "");
			var client = new RestClient ("https://driverapi.staging.drivr.com/");

			var request = new RestRequest("sessions/", Method.POST);
			request.AddParameter ("email", "jp+11@drivr.com");
			request.AddParameter ("password", "drivr11");
			request.AddParameter ("installationIdentifier", String.Format("{0}", guid));
			request.AddParameter ("appVersion", "1.0.0");
			Console.WriteLine(client.BuildUri (request).ToString());
			client.ExecuteAsync (request, response => {
				Console.WriteLine (response.Content);
			});
		}
	}
}

