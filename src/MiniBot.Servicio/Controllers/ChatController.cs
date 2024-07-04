using Microsoft.AspNetCore.Mvc;

namespace MiniBot.Servicio.Controllers
{
    [ApiController]
    [Route("api/v1/chat")]
    public class ChatController : ControllerBase
    {
       
        private readonly ILogger<ChatController> _logger;

        public ChatController(ILogger<ChatController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok(new { Mensage = "servicio fumciona correctamente!" });
        }



    }
}
