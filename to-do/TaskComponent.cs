using System;
using System.Windows.Forms;
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
            TaskComponent taskComponent = new TaskComponent(this.task);
            
            return taskComponent; 
        }

        public void SetTask(ToDoTaskDTO.ToDoTaskSummaryResponse task)
        {
            this.task = task;

        }

        public void Style(ListViewItem listViewItem)
        {
            return;
        }

        public ListViewItem ToListViewItem()
        {
            string[] row = { task.Title, task.Priority, task.DueDate.ToString(), task.Status };
            var listViewItem = new ListViewItem(row);
            listViewItem.Tag = task;

            return listViewItem; 
        }

       
    }
}
