using System;
using System.Collections.Generic;
using to_do.DTOs;

namespace to_do.State.Filter.Task
{
    public class TaskPastDueFilter : ITaskFilter
    {
        public TaskPastDueFilter()
        {
        }

        public List<ToDoTaskDTO.ToDoTaskSummaryResponse> filter(List<ToDoTaskDTO.ToDoTaskSummaryResponse> tasks)
        {
            return tasks.FindAll(t => t.DueDate < DateTime.Now);
        }
    }
}
