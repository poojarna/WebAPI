using Microsoft.AspNetCore.Mvc;

namespace WebAPIV4.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // URL will be: /api/MyName
    public class MyNameController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { name = "John Doe" }); // ← Replace your name here
        }
    }
}
