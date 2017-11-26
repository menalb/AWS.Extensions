using AWS.SimpleNotificationService.Models;

namespace AWS.SimpleNotificationService.Publishing
{
    public interface INotificationPublisher
    {
        PublishResult Publish<T>(T message) where T : IMessageBase;
        PublishResult Publish<T>(T message, string subject) where T : IMessageBase;
    }
}