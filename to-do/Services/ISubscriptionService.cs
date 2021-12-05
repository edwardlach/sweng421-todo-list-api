using System;
using System.Threading.Tasks;
using to_do.Services.@abstract;
using to_do.DTOs;
namespace to_do.Services
{
    public interface ISubscriptionService : IAbstractCreateReadUpdateService<
        SubscriptionDTO.SubscriptionResponse,
        SubscriptionDTO.SubscriptionCreateRequest,
        SubscriptionDTO.SubscriptionUpdateRequest>
    {
        Task<ChangeDTO.ChangeCollectionResponse> ReadSubscribedChanges(int subscriptionId);
    }
}
