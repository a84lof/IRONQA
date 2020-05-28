namespace IRONQA.API.HELPERS
{
    using NUnit.Framework;
    using RestSharp;
    using RestSharp.Serialization.Json;
    using System;
    using System.Collections.Generic;
    
    public class Authenticate
    {
        public static string SessionId = "";
        public static string BrowserId = "";

        public static void Auth(string email)
        {
            //Send the request
            RestClient client = new RestClient("http://betaservices.ironsolutions.com/ironservicestack");
            RestRequest request = new RestRequest("/authenticate/credentials", Method.POST);
            request.AddJsonBody(new {username = email, password = ""});
            IRestResponse response = client.Execute(request);

            //Dictionary only works for flat heirarchy
            JsonDeserializer json = new JsonDeserializer();
            Dictionary<String,String> output = json.Deserialize<Dictionary<string,string>>(response);
            
            SessionId = output["sessionId"];

            //Parse Meta for BrowserId
            string fullMeta = output["meta"];
            string[] parsedMeta = fullMeta.Split("\",\"");
            for (int i=0; i<=parsedMeta.Length-1; i++)
            { 
                string keyVal = parsedMeta[i];
                if (keyVal.Contains("BrowserId"))
                {
                    string[] bid = keyVal.Split("\":\"");
                    BrowserId = bid[1];
                }
            }
        }
    }
}
    