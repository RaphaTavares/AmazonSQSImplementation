using Amazon.SQS.Model;
using GlobalMantics_Sqs_Api.Models;

namespace GlobalMantics_Sqs_Api.Services
{
    public interface ISqsService
    {
        Task<SendMessageResponse> SendMessageToSqsQueue(TicketRequest ticket);
    }
}
