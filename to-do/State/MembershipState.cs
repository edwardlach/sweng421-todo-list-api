using System;
using System.Collections.Generic;
using to_do.DTOs;
namespace to_do.State
{
    public class MembershipState : AbstractState<MembershipDTO.MembershipResponse>
    {
        public MembershipState(List<MembershipDTO.MembershipResponse> initialState)
            : base(initialState) {}
    }
}
