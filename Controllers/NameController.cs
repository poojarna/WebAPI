using Microsoft.AspNetCore.Mvc;

namespace MyWebApiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            var name = new { Name = "Nirupama Poojari" };
            return Ok(name);
        }
    }
}