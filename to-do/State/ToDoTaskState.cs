using System;
using System.Collections.Generic;
using to_do.DTOs;
namespace to_do.State
{
    public class ToDoTaskState : AbstractState<ToDoTaskDTO.ToDoTaskSummaryResponse>
    {
        public ToDoTaskState(List<ToDoTaskDTO.ToDoTaskSummaryResponse> initialState)
            : base(initialState) {}
    }
}
