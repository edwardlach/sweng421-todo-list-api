using System;
using Microsoft.AspNetCore.Mvc;
using to_do_api.DTOs;
using to_do_api.Services;
namespace to_do_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubscriptionsController : ControllerBase
    {
        private readonly ISubscriptionService subscriptionService;

        public SubscriptionsController(ISubscriptionService subscriptionService)
        {
            this.subscriptionService = subscriptionService;
        }

        // POST subscriptions
        [HttpPost]
        public SubscriptionDTO.SubscriptionResponse Create(SubscriptionDTO.SubscriptionCreateRequest toCreate)
        {
            return new SubscriptionDTO.SubscriptionResponse(
                this.subscriptionService.Create(toCreate.ToModel()));
        }

        // GET subscriptions/{id}
        [HttpGet("{id}")]
        public SubscriptionDTO.SubscriptionResponse Read(int id)
        {
            return new SubscriptionDTO.SubscriptionResponse(this.subscriptionService.Read(id));
        }

        // GET subscriptions/{id}/changes
        [HttpGet("{id}/changes")]
        public ChangeDTO.ChangeCollectionResponse ReadSubscribedChanges(int id)
        {
            return new ChangeDTO.ChangeCollectionResponse(
                this.subscriptionService.ReadChangesForSubscription(id));
        }      

        // PUT subscriptions/{id}
        [HttpPut("{id}")]
        public SubscriptionDTO.SubscriptionResponse Update(int id, SubscriptionDTO.SubscriptionUpdateRequest updates)
        {
            return new SubscriptionDTO.SubscriptionResponse(
                this.subscriptionService.Update(id, updates.ToModel()));
        }
    }
}
