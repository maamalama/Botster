using Microsoft.AspNetCore.Mvc;

namespace Botster.Telegram.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("Working");
    }
}