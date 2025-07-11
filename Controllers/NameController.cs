using Microsoft.AspNetCore.Mvc;

namespace WebAPIV4.Controllers
{
    [ApiController]
    [Route("/")] // <- Root URL
    public class MyNameController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { name = "Nirupama Poojari" });
        }
    }
}
