using System;

namespace AWS.SimpleNotificationService.Models
{
    public class TopicARNMapping
    {
        public TopicARNMapping(string topic, string arn)
        {
            if (string.IsNullOrEmpty(topic))
                throw new ArgumentException("Topic not set");
            if (string.IsNullOrEmpty(arn))
                throw new ArgumentException("ARN not set");

            Topic = topic;
            ARN = arn;
        }

        public string Topic { get; }
        public string ARN { get; }
    }
}