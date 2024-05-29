using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace HelloWorldWebApp.Controllers
{
    [ApiController]
    [Route("")]
    public class HelloController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Congratulations, it works!");
        }
    }
}
