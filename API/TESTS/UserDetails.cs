namespace IRONQA.API.TESTS
{
    using IRONQA.API.HELPERS;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using RestSharp;

    [TestFixture]
    public class UserDetails
    {   
        
        [Test]
        public void GetCreditsAvailable()
        {
            // Authenticate the user
            Authenticate.Auth("proadmin@usigqa.com");

            //Send the request
            RestClient client = new RestClient("http://betaservices.ironsolutions.com/ironservicestack");
            RestRequest request = new RestRequest("/accounts/credits", Method.GET);
            request.AddParameter("X-ss-id", Authenticate.SessionId, ParameterType.HttpHeader);
            request.AddParameter("X-ss-pid", Authenticate.SessionId, ParameterType.HttpHeader);
            request.AddParameter("X-iron-browserId", Authenticate.BrowserId, ParameterType.HttpHeader);
            request.AddHeader("Accept", "application/json");
            IRestResponse response = client.Execute(request);

            //Parse the response
            string[] parseResp = response.Content.Split("[");
            //Split out features
            string[] features = parseResp[1].Split("},{");
            for (int i=0; i<=features.Length-1; i++)
            { 
                string nodes = features[i]
                    .Replace("{",string.Empty)
                    .Replace("}",string.Empty)
                    .Replace("]",string.Empty);
                Util.Log(nodes);
            }
        }
    }
}