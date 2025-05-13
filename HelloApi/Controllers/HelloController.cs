using Microsoft.AspNetCore.Mvc;

namespace HelloApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateHello([FromBody] string message)
        {
            return CreatedAtAction(nameof(CreateHello), new { Message = message });
        }

        [HttpDelete]
        public IActionResult DeleteHello()
        {
            return NoContent();
        }
    }
}
