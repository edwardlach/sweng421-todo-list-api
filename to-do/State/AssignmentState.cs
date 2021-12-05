using System;
using System.Collections.Generic;
using to_do.DTOs;
namespace to_do.State
{
    public class AssignmentState : AbstractState<AssignmentDTO.AssignmentResponse>
    {
        public AssignmentState(List<AssignmentDTO.AssignmentResponse> initialState)
            : base(initialState) {}
    }
}
