using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;

using AWS.SimpleNotificationService.Models;
using AWS.SimpleNotificationService.Mapping;

namespace AWS.SimpleNotificationService.Publishing
{
    public class AWSSNSPublisher : INotificationPublisher
    {
        private readonly IEnumerable<TopicARNMapping> _topicARNMappings;
        private readonly IAmazonSimpleNotificationService _client;

        public AWSSNSPublisher(IEnumerable<TopicARNMapping> topicARNMappings, IAmazonSimpleNotificationService client) : this(topicARNMappings)
        {
            _client = client;
        }

        private IAmazonSimpleNotificationService GetSNSClient()
        {
            if (_client == null)
                return new AmazonSimpleNotificationServiceClient();
            return _client;
        }

        public AWSSNSPublisher(TopicARNMapping topicARNMapping)
        {
            _topicARNMappings = new List<TopicARNMapping> { topicARNMapping };
        }

        public AWSSNSPublisher(IEnumerable<TopicARNMapping> topicARNMappings)
        {
            _topicARNMappings = topicARNMappings;
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

            using (var client = GetSNSClient())
            {
                return ProcessResponse(client.Publish(arn, jsonMessage, subject));
            }
        }

        private string ResolveARN(string topic)
        {
            return _topicARNMappings.Single(mapping => mapping.Topic == topic).ARN;
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