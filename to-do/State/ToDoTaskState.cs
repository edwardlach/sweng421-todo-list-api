using System;
using System.Collections.Generic;
using to_do.DTOs;
namespace to_do.State
{
    public class ToDoTaskState : AbstractState<ToDoTaskDTO.ToDoTaskResponse>
    {
        public ToDoTaskState(List<ToDoTaskDTO.ToDoTaskResponse> initialState)
            : base(initialState) {}
    }
}
