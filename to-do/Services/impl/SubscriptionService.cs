using System;
using System.Threading.Tasks;
using System.Net.Http;
using to_do.Services.@abstract;
using to_do.DTOs;
namespace to_do.Services.impl
{
    public class SubscriptionService : AbstractCreateReadUpdateService<
        SubscriptionDTO.SubscriptionResponse,
        SubscriptionDTO.SubscriptionCreateRequest,
        SubscriptionDTO.SubscriptionUpdateRequest>,
        ISubscriptionService
    {
        public SubscriptionService(
            HttpClient http,
            string host) : base(http, host, APIResource.SUBSCRIPTIONS) {}

        public async Task<ChangeDTO.ChangeCollectionResponse> ReadSubscribedChanges(int subscriptionId)
        {
            HttpResponseMessage responseMessage = await http.GetAsync(
                host + resource + "/" + subscriptionId + "/changes");
            return await GetResponseFromMessage<ChangeDTO.ChangeCollectionResponse>(responseMessage);
        }
    }
}
