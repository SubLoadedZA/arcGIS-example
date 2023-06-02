using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace arcGIS.Services
{
    public class ArcGISService
    {
        private HttpClient _client;

        public ArcGISService()
        {
            _client = new HttpClient();
        }

        public async Task<JObject> GetFeatureInfo(string url)
        {
            HttpResponseMessage response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                JObject featureInfo = JObject.Parse(content);
                return featureInfo;
            }
            else
            {
                throw new Exception("Error calling ArcGIS service");
            }
        }
    }
}
