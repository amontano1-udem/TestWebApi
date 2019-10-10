using Microsoft.AspNetCore.Mvc;

namespace TestWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Blog : ControllerBase
    {
        [HttpGet]
        public string Read(){
            return "read";
        }

        [HttpPost]
        public string Create(){
            return "create";
        }

        [HttpPut]
        public string Update(){
            return "update";
        }

        [HttpDelete]
        public string Delete(){
            return "delete";
        }
    }
}