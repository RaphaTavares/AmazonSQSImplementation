using Newtonsoft.Json;

namespace GlobalMantics_Sqs_Api.Models
{
    public class TicketRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        
        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
