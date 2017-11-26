using AWS.SimpleNotificationService.Models;

namespace AWS.SimpleNotificationService.Gateways
{
    public interface INotificationPublisher
    {
        PublishResult Publish<T>(T message) where T : IMessageBase;
        PublishResult Publish<T>(T message, string subject) where T : IMessageBase;
    }
}