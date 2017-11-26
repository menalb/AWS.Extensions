using Amazon.SimpleNotificationService.Model;
using AWS.SimpleNotificationService.Mapping;
using AWS.SimpleNotificationService.Models;
using AWS.SimpleNotificationService.Publishing;
using System.Collections.Generic;
using Xunit;

namespace AWS.SimpleNotificationService.Tests.Publisher
{
    public class AWSSNSPublisherTests
    {
        private readonly AWSSNSPublisher _sut;
        private readonly AWSSNSClient_Fake _client;
        private readonly IList<TopicARNMapping> _topicARNMappings;

        public AWSSNSPublisherTests()
        {
            _client = new AWSSNSClient_Fake();
            _topicARNMappings = new List<TopicARNMapping> { new TopicARNMapping("foo", "fooARN") };
            _sut = new AWSSNSPublisher(_topicARNMappings, _client);
        }

        [Fact]
        public void GivenAMessage_ItPublishTheMessage()
        {
            var message = new MessageToPublish { Name = "hello" };
            var response = new PublishResponse { HttpStatusCode = System.Net.HttpStatusCode.OK, MessageId = "123" };
            _client.SetPublishResponse(response);

            var result = _sut.Publish(message);

            Assert.Equal(response.HttpStatusCode, result.HttpStatusCode);
            Assert.Equal(response.MessageId, result.MessageId);
        }
    }

    [AWSSNSMapping("foo")]
    public class MessageToPublish : IMessageBase { public string Name { get; set; } }
}