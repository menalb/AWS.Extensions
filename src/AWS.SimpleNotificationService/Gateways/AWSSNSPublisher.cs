using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;

using AWS.SimpleNotificationService.Models;
using AWS.SimpleNotificationService.Infrastructure;

namespace AWS.SimpleNotificationService.Gateways
{
    public class AWSSNSPublisher : INotificationPublisher
    {
        private readonly IEnumerable<TopicARNMapping> _snsARNResolver;

        public AWSSNSPublisher(IEnumerable<TopicARNMapping> snsARNResolver)
        {
            _snsARNResolver = snsARNResolver;
        }

        public PublishResult Publish<T>(T message) where T : IMessageBase
        {
            return PublishToSNS(message, message.GetTopicName());
        }

        public PublishResult Publish<T>(T message, string subject) where T : IMessageBase
        {
            return PublishToSNS(message, subject);
        }

        private PublishResult PublishToSNS<T>(T message, string subject) where T : IMessageBase
        {
            var jsonMessage = JsonConvert.SerializeObject(message);

            var arn = ResolveARN(message.GetTopicName());

            using (var client = new AmazonSimpleNotificationServiceClient())
            {
                return ProcessResponse(client.Publish(arn, jsonMessage, subject));
            }
        }

        private string ResolveARN(string topic)
        {
            return _snsARNResolver.Single(mapping => mapping.Topic == topic).ARN;
        }

        private PublishResult ProcessResponse(PublishResponse response)
        {
            return new PublishResult
            {
                MessageId = response.MessageId,
                ContentLength = response.ContentLength,
                HttpStatusCode = response.HttpStatusCode
            };
        }        
    }
}