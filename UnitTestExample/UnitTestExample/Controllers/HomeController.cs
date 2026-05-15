using Microsoft.AspNetCore.Mvc;

namespace UnitTestExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Hello, World! Manish i am in home";
        }
    }
}