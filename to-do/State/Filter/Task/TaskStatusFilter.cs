using System;
using System.Collections.Generic;
using to_do.DTOs;

namespace to_do.State.Filter.Task
{
    public class TaskStatusFilter : ITaskFilter
    {
        private string status;

        public TaskStatusFilter(string status)
        {
            this.status = status;
        }

        public List<ToDoTaskDTO.ToDoTaskSummaryResponse> filter(List<ToDoTaskDTO.ToDoTaskSummaryResponse> tasks)
        {
            return tasks.FindAll(t => t.Status == this.status);
        }
    }
}
