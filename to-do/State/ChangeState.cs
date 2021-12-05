using System;
using System.Collections.Generic;
using to_do.DTOs;
namespace to_do.State
{
    public class ChangeState : AbstractState<ChangeDTO.ChangeResponse>
    {
        public ChangeState(List<ChangeDTO.ChangeResponse> initialState) : base(initialState) {}
    }
}
