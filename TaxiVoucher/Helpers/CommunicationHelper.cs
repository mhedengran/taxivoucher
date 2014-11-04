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
			request.AddParameter ("email", "pt+cph@theill.com");
			request.AddParameter ("password", "123456");
			request.AddParameter ("installationIdentifier", String.Format("{0}", guid));
			request.AddParameter ("appVersion", "1.0.0");
			client.ExecuteAsync<JSONResponse> (request, response => {
				string temp = response.Content.Replace(",", "\n");
				string temp2 = temp.Replace("{", "\n{\n");
				string temp3 = temp2.Replace("}","\n}\n");
				Console.WriteLine(String.Format("{0}, {1}, {2}, {3}", response.Data.Driver.Id, response.Data.Driver.Name, response.Data.Driver.FirstName, response.Data.Driver.LastName));
				Console.WriteLine (temp3);


			});
		}
	}
}

