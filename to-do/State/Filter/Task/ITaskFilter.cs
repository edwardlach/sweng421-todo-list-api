using System;
using System.Collections.Generic;
using to_do.DTOs;
namespace to_do.State.Filter.Task
{
    public interface ITaskFilter
    {
        List<ToDoTaskDTO.ToDoTaskSummaryResponse> filter(List<ToDoTaskDTO.ToDoTaskSummaryResponse> tasks);
    }
}
