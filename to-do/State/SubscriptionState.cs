using System;
using System.Collections.Generic;
using to_do.DTOs;
namespace to_do.State
{
    public class SubscriptionState : AbstractState<SubscriptionDTO.SubscriptionResponse>
    {
        public SubscriptionState(List<SubscriptionDTO.SubscriptionResponse> initialState)
            : base(initialState) {}
    }
}
