using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/connections")]
    [ApiController]
    public class ConnectionsController : ControllerBase
    {
        [HttpGet]
        [Route("app")]
        public IActionResult App()
        {
            return Ok("The application is being active");
        }

        [HttpGet]
        [Route("database")]
        public IActionResult Database()
        {
            return Ok("The application is being connected to the database");
        }
    }
}
