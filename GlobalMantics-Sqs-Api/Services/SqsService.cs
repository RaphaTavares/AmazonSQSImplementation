using Amazon.SQS;
using Amazon.SQS.Model;
using GlobalMantics_Sqs_Api.Models;

namespace GlobalMantics_Sqs_Api.Services
{
    public class SqsService : ISqsService
    {
        private readonly IAmazonSQS _sqsClient;
        private readonly IConfiguration _configuration;
        public ConfigurationManager Configuration { get; set; }

        public SqsService(IAmazonSQS sqsClient, IConfiguration configuration)
        {
            _sqsClient = sqsClient;
            _configuration = configuration;
        }

        public async Task<SendMessageResponse> SendMessageToSqsQueue(TicketRequest ticket)
        {
            var sendMessageRequest = new SendMessageRequest
            {
                QueueUrl = _configuration.GetValue<string>("AWS:SQS:PluralsightCourseSQS:URL"),
                MessageBody = ticket.Serialize()
            };

            return await _sqsClient.SendMessageAsync(sendMessageRequest);
        }
    }
}
