using System;
using System.Collections.Generic;
using to_do.DTOs;
namespace to_do.State.Sort.Task
{
    public interface ISortFilter
    {
        List<ToDoTaskDTO.ToDoTaskSummaryResponse> sort(List<ToDoTaskDTO.ToDoTaskSummaryResponse> tasks);
    }
}
