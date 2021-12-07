using System;
using System.Collections.Generic;
using to_do.DTOs;

namespace to_do.State.Filter.Task
{
    public class TaskPriorityFilter : ITaskFilter
    {
        private string priority;

        public TaskPriorityFilter(string priority)
        {
            this.priority = priority;
        }

        public List<ToDoTaskDTO.ToDoTaskSummaryResponse> filter(List<ToDoTaskDTO.ToDoTaskSummaryResponse> tasks)
        {
            return tasks.FindAll(t => t.Priority == this.priority);
        }
    }
}
