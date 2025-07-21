using KafkaWebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KafkaWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KafkaController : ControllerBase
    {
        private readonly KafkaProducerService _producer;

        public KafkaController(KafkaProducerService producer)
        {
            _producer = producer;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendMessage([FromBody] string message)
        {
            await _producer.SendMessageAsync(message);
            return Ok("Message sent to Kafka topic!");
        }
    }
}
