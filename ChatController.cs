using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace LocalAIChatbot.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly IConfiguration _config;

        public ChatController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost("send")] 
        public async Task<IActionResult> SendMessage([FromBody] UserMessage userMessage)
        {
            // Simulated AI response
            var aiResponse = $"You said: {userMessage.Message}";

            return Ok(new { response = aiResponse });
        }
    }

    public class UserMessage
    {
        public string Message { get; set; }
    }
}
