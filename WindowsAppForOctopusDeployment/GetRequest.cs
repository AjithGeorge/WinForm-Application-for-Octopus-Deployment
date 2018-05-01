using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using static WindowsAppForOctopusDeployment.ChannelDetails;

namespace WindowsAppForOctopusDeployment
{
    public class GetRequest
    {
        public string AllPopulate(string apikey, string Baseurl,string Endpoint)
        {
            string baseurl = Baseurl;
            string APIKey = apikey;
            string endpoint = Endpoint;
            WebRequest req = WebRequest.Create(baseurl + endpoint);
            req.Method = "GET";
            req.Headers["X-Octopus-ApiKey"] = APIKey;

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(resp.GetResponseStream());

            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            return responseFromServer;
        }
        }
}
