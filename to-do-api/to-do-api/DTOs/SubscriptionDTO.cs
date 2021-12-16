using System;
using System.Collections.Generic;
using to_do_api.DTOs.@abstract;
using to_do_api.Models;
namespace to_do_api.DTOs
{
    public class SubscriptionDTO
    {
        public class SubscriptionCreateRequest : AbstractTimestampedDTO.AbstractTimestampedCreateRequest<Subscription>
        {
            public int ListId { get; set; }

            public int UserId { get; set; }

            public override Subscription ToModel()
            {
                Subscription subscription = new Subscription();
                ToModelHelper(subscription);
                subscription.LastAccessed = DateTime.UtcNow;
                subscription.ListId = this.ListId;
                subscription.UserId = this.UserId;
                return subscription;
            }
        }

        public class SubscribedChangesRequest
        {
            public int ListId { get; set; }

            public DateTime LastAccessd { get; set; }

            public Subscription ToModel()
            {
                Subscription subscription = new Subscription();
                subscription.ListId = this.ListId;
                subscription.LastAccessed = this.LastAccessd;
                return subscription;
            }
        }

        public class SubscriptionResponse : AbstractTimestampedDTO.AbstractTimestampedResponse<Subscription>
        {
            public SubscriptionResponse(Subscription entity) : base (entity)
            {
                this.LastAccessd = entity.LastAccessed;
                this.Deleted = entity.Deleted;
                this.ListId = entity.ListId;
                this.UserId = entity.UserId;
            }

            public Boolean Deleted { get; set; }

            public DateTime LastAccessd { get; set; }

            public int ListId { get; set; }

            public int UserId { get; set; }
        }

        public class SubscriptionCollectionResponse : AbstractCollectionDTO.AbstractCollectionResponse<
            Subscription, SubscriptionDTO.SubscriptionResponse>
        {
            public SubscriptionCollectionResponse(List<Subscription> subscriptions) : base(subscriptions) {}

            public override SubscriptionResponse ToResponse(Subscription entity)
            {
                return new SubscriptionResponse(entity);
            }
        }

        public class SubscriptionUpdateRequest : AbstractTimestampedDTO.AbstractTimestampedUpdateRequest<Subscription>
        {
            public Boolean Deleted { get; set; }

            public DateTime LastAccessd { get; set; }

            public override Subscription ToModel()
            {
                Subscription subscription = new Subscription();
                ToModelHelper(subscription);
                subscription.Deleted = this.Deleted;
                subscription.LastAccessed = this.LastAccessd;
                return subscription;
            }
        }
    }
}
