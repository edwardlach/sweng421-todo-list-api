using System;
using to_do.DTOs.@abstract;
namespace to_do.DTOs
{
    public class SubscriptionDTO
    {
        public class SubscriptionCreateRequest
        {
            public int ListId { get; set; }

            public int UserId { get; set; }
        }

        public class SubscribedChangesRequest
        {
            public int ListId { get; set; }

            public DateTime LastAccessd { get; set; }
        }

        public class SubscriptionResponse : AbstractTimestampedDTO.AbstractTimestampedResponse
        {
            public Boolean Deleted { get; set; }

            public DateTime LastAccessd { get; set; }

            public int ListId { get; set; }

            public int UserId { get; set; }
        }

        public class SubscriptionUpdateRequest : AbstractIdentifiableDTO.AbstractIdentifiableUpdateRequest
        {
            public Boolean Deleted { get; set; }

            public DateTime LastAccessd { get; set; }
        }
    }
}
