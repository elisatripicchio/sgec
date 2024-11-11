using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InicioController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("API Iniciada");
        }
    }
}