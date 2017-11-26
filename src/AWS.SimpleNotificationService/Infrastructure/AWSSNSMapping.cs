using System;

using AWS.SimpleNotificationService.Models;

namespace AWS.SimpleNotificationService.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class AWSSNSMapping : Attribute
    {

        private readonly string _topicName;
        private readonly int _topicId;

        public AWSSNSMapping(string topicName, int topicId)
        {
            _topicName = topicName;
            _topicId = topicId;
        }

        public string TopicName { get { return _topicName; } }
        public int TopicId { get { return _topicId; } }
    }

    public static class AWSSNSMappingExtensions
    {
        public static string GetTopicName(this IMessageBase message)
        {
            return (Attribute.GetCustomAttribute(message.GetType(), typeof(AWSSNSMapping)) as AWSSNSMapping).TopicName;
        }

        public static int GetTopicId(this IMessageBase message)
        {
            return (Attribute.GetCustomAttribute(message.GetType(), typeof(AWSSNSMapping)) as AWSSNSMapping).TopicId;
        }
    }
}