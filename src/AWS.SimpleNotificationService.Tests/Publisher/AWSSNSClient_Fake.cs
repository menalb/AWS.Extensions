using Amazon.Runtime;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AWS.SimpleNotificationService.Tests.Publisher
{
    internal class AWSSNSClient_Fake : IAmazonSimpleNotificationService
    {
        public IClientConfig Config => throw new System.NotImplementedException();

        private PublishResponse _publishResponse;

        public void SetPublishResponse(PublishResponse response)
        {
            _publishResponse = response;
        }

        public PublishResponse Publish(string topicArn, string message)
        {
            return _publishResponse;
        }

        public PublishResponse Publish(string topicArn, string message, string subject)
        {
            return _publishResponse;
        }

        public PublishResponse Publish(PublishRequest request)
        {
            return _publishResponse;
        }

        public AddPermissionResponse AddPermission(string topicArn, string label, List<string> awsAccountId, List<string> actionName)
        {
            throw new System.NotImplementedException();
        }

        public AddPermissionResponse AddPermission(AddPermissionRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<AddPermissionResponse> AddPermissionAsync(string topicArn, string label, List<string> awsAccountId, List<string> actionName, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<AddPermissionResponse> AddPermissionAsync(AddPermissionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public void AuthorizeS3ToPublish(string topicArn, string bucket)
        {
            throw new System.NotImplementedException();
        }

        public Task AuthorizeS3ToPublishAsync(string topicArn, string bucket)
        {
            throw new System.NotImplementedException();
        }

        public CheckIfPhoneNumberIsOptedOutResponse CheckIfPhoneNumberIsOptedOut(CheckIfPhoneNumberIsOptedOutRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<CheckIfPhoneNumberIsOptedOutResponse> CheckIfPhoneNumberIsOptedOutAsync(CheckIfPhoneNumberIsOptedOutRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public ConfirmSubscriptionResponse ConfirmSubscription(string topicArn, string token, string authenticateOnUnsubscribe)
        {
            throw new System.NotImplementedException();
        }

        public ConfirmSubscriptionResponse ConfirmSubscription(string topicArn, string token)
        {
            throw new System.NotImplementedException();
        }

        public ConfirmSubscriptionResponse ConfirmSubscription(ConfirmSubscriptionRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<ConfirmSubscriptionResponse> ConfirmSubscriptionAsync(string topicArn, string token, string authenticateOnUnsubscribe, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<ConfirmSubscriptionResponse> ConfirmSubscriptionAsync(string topicArn, string token, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<ConfirmSubscriptionResponse> ConfirmSubscriptionAsync(ConfirmSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public CreatePlatformApplicationResponse CreatePlatformApplication(CreatePlatformApplicationRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<CreatePlatformApplicationResponse> CreatePlatformApplicationAsync(CreatePlatformApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public CreatePlatformEndpointResponse CreatePlatformEndpoint(CreatePlatformEndpointRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<CreatePlatformEndpointResponse> CreatePlatformEndpointAsync(CreatePlatformEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public CreateTopicResponse CreateTopic(string name)
        {
            throw new System.NotImplementedException();
        }

        public CreateTopicResponse CreateTopic(CreateTopicRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<CreateTopicResponse> CreateTopicAsync(string name, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<CreateTopicResponse> CreateTopicAsync(CreateTopicRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public DeletePlatformApplicationResponse DeletePlatformApplication(DeletePlatformApplicationRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<DeletePlatformApplicationResponse> DeletePlatformApplicationAsync(DeletePlatformApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public DeleteTopicResponse DeleteTopic(string topicArn)
        {
            throw new System.NotImplementedException();
        }

        public DeleteTopicResponse DeleteTopic(DeleteTopicRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<DeleteTopicResponse> DeleteTopicAsync(string topicArn, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<DeleteTopicResponse> DeleteTopicAsync(DeleteTopicRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {

        }

        public Topic FindTopic(string topicName)
        {
            throw new System.NotImplementedException();
        }

        public Task<Topic> FindTopicAsync(string topicName)
        {
            throw new System.NotImplementedException();
        }

        public GetEndpointAttributesResponse GetEndpointAttributes(GetEndpointAttributesRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<GetEndpointAttributesResponse> GetEndpointAttributesAsync(GetEndpointAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public GetPlatformApplicationAttributesResponse GetPlatformApplicationAttributes(GetPlatformApplicationAttributesRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<GetPlatformApplicationAttributesResponse> GetPlatformApplicationAttributesAsync(GetPlatformApplicationAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public GetSMSAttributesResponse GetSMSAttributes(GetSMSAttributesRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<GetSMSAttributesResponse> GetSMSAttributesAsync(GetSMSAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public GetSubscriptionAttributesResponse GetSubscriptionAttributes(string subscriptionArn)
        {
            throw new System.NotImplementedException();
        }

        public GetSubscriptionAttributesResponse GetSubscriptionAttributes(GetSubscriptionAttributesRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<GetSubscriptionAttributesResponse> GetSubscriptionAttributesAsync(string subscriptionArn, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<GetSubscriptionAttributesResponse> GetSubscriptionAttributesAsync(GetSubscriptionAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public GetTopicAttributesResponse GetTopicAttributes(string topicArn)
        {
            throw new System.NotImplementedException();
        }

        public GetTopicAttributesResponse GetTopicAttributes(GetTopicAttributesRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<GetTopicAttributesResponse> GetTopicAttributesAsync(string topicArn, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<GetTopicAttributesResponse> GetTopicAttributesAsync(GetTopicAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public ListEndpointsByPlatformApplicationResponse ListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<ListEndpointsByPlatformApplicationResponse> ListEndpointsByPlatformApplicationAsync(ListEndpointsByPlatformApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public ListPhoneNumbersOptedOutResponse ListPhoneNumbersOptedOut(ListPhoneNumbersOptedOutRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<ListPhoneNumbersOptedOutResponse> ListPhoneNumbersOptedOutAsync(ListPhoneNumbersOptedOutRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public ListPlatformApplicationsResponse ListPlatformApplications()
        {
            throw new System.NotImplementedException();
        }

        public ListPlatformApplicationsResponse ListPlatformApplications(ListPlatformApplicationsRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<ListPlatformApplicationsResponse> ListPlatformApplicationsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<ListPlatformApplicationsResponse> ListPlatformApplicationsAsync(ListPlatformApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public ListSubscriptionsResponse ListSubscriptions()
        {
            throw new System.NotImplementedException();
        }

        public ListSubscriptionsResponse ListSubscriptions(string nextToken)
        {
            throw new System.NotImplementedException();
        }

        public ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<ListSubscriptionsResponse> ListSubscriptionsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<ListSubscriptionsResponse> ListSubscriptionsAsync(string nextToken, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(string topicArn, string nextToken)
        {
            throw new System.NotImplementedException();
        }

        public ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(string topicArn)
        {
            throw new System.NotImplementedException();
        }

        public ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<ListSubscriptionsByTopicResponse> ListSubscriptionsByTopicAsync(string topicArn, string nextToken, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<ListSubscriptionsByTopicResponse> ListSubscriptionsByTopicAsync(string topicArn, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<ListSubscriptionsByTopicResponse> ListSubscriptionsByTopicAsync(ListSubscriptionsByTopicRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public ListTopicsResponse ListTopics()
        {
            throw new System.NotImplementedException();
        }

        public ListTopicsResponse ListTopics(string nextToken)
        {
            throw new System.NotImplementedException();
        }

        public ListTopicsResponse ListTopics(ListTopicsRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<ListTopicsResponse> ListTopicsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<ListTopicsResponse> ListTopicsAsync(string nextToken, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<ListTopicsResponse> ListTopicsAsync(ListTopicsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public OptInPhoneNumberResponse OptInPhoneNumber(OptInPhoneNumberRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<OptInPhoneNumberResponse> OptInPhoneNumberAsync(OptInPhoneNumberRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }        

        public Task<PublishResponse> PublishAsync(string topicArn, string message, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<PublishResponse> PublishAsync(string topicArn, string message, string subject, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<PublishResponse> PublishAsync(PublishRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public RemovePermissionResponse RemovePermission(string topicArn, string label)
        {
            throw new System.NotImplementedException();
        }

        public RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<RemovePermissionResponse> RemovePermissionAsync(string topicArn, string label, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public SetEndpointAttributesResponse SetEndpointAttributes(SetEndpointAttributesRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<SetEndpointAttributesResponse> SetEndpointAttributesAsync(SetEndpointAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public SetPlatformApplicationAttributesResponse SetPlatformApplicationAttributes(SetPlatformApplicationAttributesRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<SetPlatformApplicationAttributesResponse> SetPlatformApplicationAttributesAsync(SetPlatformApplicationAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public SetSMSAttributesResponse SetSMSAttributes(SetSMSAttributesRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<SetSMSAttributesResponse> SetSMSAttributesAsync(SetSMSAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public SetSubscriptionAttributesResponse SetSubscriptionAttributes(string subscriptionArn, string attributeName, string attributeValue)
        {
            throw new System.NotImplementedException();
        }

        public SetSubscriptionAttributesResponse SetSubscriptionAttributes(SetSubscriptionAttributesRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<SetSubscriptionAttributesResponse> SetSubscriptionAttributesAsync(string subscriptionArn, string attributeName, string attributeValue, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<SetSubscriptionAttributesResponse> SetSubscriptionAttributesAsync(SetSubscriptionAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public SetTopicAttributesResponse SetTopicAttributes(string topicArn, string attributeName, string attributeValue)
        {
            throw new System.NotImplementedException();
        }

        public SetTopicAttributesResponse SetTopicAttributes(SetTopicAttributesRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<SetTopicAttributesResponse> SetTopicAttributesAsync(string topicArn, string attributeName, string attributeValue, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<SetTopicAttributesResponse> SetTopicAttributesAsync(SetTopicAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public SubscribeResponse Subscribe(string topicArn, string protocol, string endpoint)
        {
            throw new System.NotImplementedException();
        }

        public SubscribeResponse Subscribe(SubscribeRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<SubscribeResponse> SubscribeAsync(string topicArn, string protocol, string endpoint, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<SubscribeResponse> SubscribeAsync(SubscribeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public string SubscribeQueue(string topicArn, ICoreAmazonSQS sqsClient, string sqsQueueUrl)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> SubscribeQueueAsync(string topicArn, ICoreAmazonSQS sqsClient, string sqsQueueUrl)
        {
            throw new System.NotImplementedException();
        }

        public IDictionary<string, string> SubscribeQueueToTopics(IList<string> topicArns, ICoreAmazonSQS sqsClient, string sqsQueueUrl)
        {
            throw new System.NotImplementedException();
        }

        public Task<IDictionary<string, string>> SubscribeQueueToTopicsAsync(IList<string> topicArns, ICoreAmazonSQS sqsClient, string sqsQueueUrl)
        {
            throw new System.NotImplementedException();
        }

        public UnsubscribeResponse Unsubscribe(string subscriptionArn)
        {
            throw new System.NotImplementedException();
        }

        public UnsubscribeResponse Unsubscribe(UnsubscribeRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<UnsubscribeResponse> UnsubscribeAsync(string subscriptionArn, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }

        public Task<UnsubscribeResponse> UnsubscribeAsync(UnsubscribeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }
    }
}