using Microsoft.AspNetCore.Mvc;

namespace WebAPIV4.Controllers
{
    [ApiController]
    [Route("[controller]")] // This sets the route to /MyName
    public class MyNameController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { name = "John Doe" }); // <-- Replace with your name
        }
    }
}
