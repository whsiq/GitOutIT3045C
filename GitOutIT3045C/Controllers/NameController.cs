using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitOutIT3045C.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var name = "Chase Staggs";
            return Ok(new { Name = name });
        }
    }
}
