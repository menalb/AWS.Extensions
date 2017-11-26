using System.Net;

namespace AWS.SimpleNotificationService.Models
{
    public class PublishResult
    {
        public string MessageId { get; set; }
        public long ContentLength { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
    }
}