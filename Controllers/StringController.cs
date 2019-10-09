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
            // var rng = new Random();
            // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            // {
            //     Date = DateTime.Now.AddDays(index),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Summaries[rng.Next(Summaries.Length)]
            // })
            // .ToArray();
        }
    }
}