using System;
using System.Collections.Generic;
using to_do.DTOs;

namespace to_do.State.Sort.Task
{
    internal class TaskNoSort : ISortFilter
    {
        public List<ToDoTaskDTO.ToDoTaskSummaryResponse> sort(List<ToDoTaskDTO.ToDoTaskSummaryResponse> tasks)
        {
            return tasks;
        }
    }
}
