using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using arcGIS.Services;
using Newtonsoft.Json.Linq;

namespace arcGIS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GisController : ControllerBase
    {
        private readonly ArcGISService _arcGISService;

        public GisController(ArcGISService arcGISService)
        {
            _arcGISService = arcGISService;
        }

        [HttpGet]
        public async Task<JObject> Get()
        {
            var url = "https://services.arcgis.com/P3ePLMYs2RVChkJx/arcgis/rest/services/USA_States_Generalized/FeatureServer/0/query?where=1%3D1&outFields=*&outSR=4326&f=json";
            JObject featureInfo = await _arcGISService.GetFeatureInfo(url);
            return featureInfo;
        }
    }
}