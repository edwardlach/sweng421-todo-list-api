using System;
using System.Collections.Generic;
using to_do.DTOs;
namespace to_do.State
{
    public class ToDoListState : AbstractState<ToDoListDTO.ToDoListResponse>
    {
        public ToDoListState(List<ToDoListDTO.ToDoListResponse> initialState)
            : base(initialState) {}
    }
}
