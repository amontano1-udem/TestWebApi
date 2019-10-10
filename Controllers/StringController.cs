using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace TestWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StringController : ControllerBase
    {
        public string appName { get; set; }

        public StringController(IConfiguration config){
            appName = config.GetValue<string>("applicationName");
        }

        [HttpGet]
        public string Get()
        {
            return appName;
        }
    }
}