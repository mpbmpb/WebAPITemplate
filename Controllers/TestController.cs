using Microsoft.AspNetCore.Mvc;

namespace WebAPITemplate.Controllers
{
    public class TestController : Controller
    {
        [HttpGet("api/user")]
        public IActionResult Get()
        {
            return Ok(new {name = "Mark"});
        }
    }
}