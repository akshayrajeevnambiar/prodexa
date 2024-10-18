using Microsoft.AspNetCore.Mvc;

namespace TaskManagerAPI.Controllers
{
    [ApiController] // This attribute tells ASP.NET that this class is an API controller
    [Route("api/[controller]")] // This defines the route. It maps to "api/task" for this controller.
    public class TaskController : ControllerBase
    {
        // This is a simple GET method that returns a test message
        [HttpGet]
        public IActionResult GetTask()
        {
            return Ok("Hello from TaskController");
        }
    }
}
