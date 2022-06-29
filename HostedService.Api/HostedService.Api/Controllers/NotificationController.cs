using HostedService.Api.SignalR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HostedService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly ILogger<NotificationController> _logger;
        private readonly MockHub _mockHub;

        public NotificationController(ILogger<NotificationController> logger,SignalR.MockHub mockHub)
        {
            _logger = logger;
            _mockHub = mockHub;
        }
        [HttpPost]
        public IActionResult Index([FromBody] string message)
        {
            _logger.LogInformation("Message received {msg}", new { msg = message });
            _mockHub.Notify();
            return NoContent();
        }
    }
}
