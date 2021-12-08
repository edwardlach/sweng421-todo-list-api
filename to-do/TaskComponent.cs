using System;
using to_do.DTOs;
namespace to_do
{
    public class TaskComponent : ICloneable, ITaskComponent
    {
        private ToDoTaskDTO.ToDoTaskSummaryResponse task;
        
        
        public TaskComponent(ToDoTaskDTO.ToDoTaskSummaryResponse task)
        {
            this.task = task;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public void Style()
        {
            throw new NotImplementedException();
        }
    }
}
