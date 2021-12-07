using System;
using System.Collections.Generic;
using to_do.DTOs;

namespace to_do.State.Filter.Task
{
    public class TaskNoFilter : ITaskFilter
    {
        public TaskNoFilter()
        {
        }

        public List<ToDoTaskDTO.ToDoTaskSummaryResponse> filter(List<ToDoTaskDTO.ToDoTaskSummaryResponse> tasks)
        {
            return tasks;
        }
    }
}
