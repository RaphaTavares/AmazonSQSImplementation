using GlobalMantics_Sqs_Api.Models;
using GlobalMantics_Sqs_Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace GlobalMantics_Sqs_Api.Controllers
{
    public class QueueController : ControllerBase
    {
        private readonly ISqsService _sqsService;

        public QueueController(ISqsService sqsService)
        {
            _sqsService = sqsService;
        }

        [HttpPost]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(TicketRequest ticket)
        {
            var response = await _sqsService.SendMessageToSqsQueue(ticket);

            if(response == null)
            {
                return BadRequest();
            }
            return Ok();
        }

    }
}
