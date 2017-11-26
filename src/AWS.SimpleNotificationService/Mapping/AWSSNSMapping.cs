using System;

using AWS.SimpleNotificationService.Models;

namespace AWS.SimpleNotificationService.Mapping
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class AWSSNSMapping : Attribute
    {

        private readonly string _topicName;        

        public AWSSNSMapping(string topicName)
        {
            _topicName = topicName;            
        }

        public string TopicName { get { return _topicName; } }
    }

    public static class AWSSNSMappingExtensions
    {
        public static string GetTopicName(this IMessageBase message)
        {
            return (Attribute.GetCustomAttribute(message.GetType(), typeof(AWSSNSMapping)) as AWSSNSMapping).TopicName;
        }        
    }
}