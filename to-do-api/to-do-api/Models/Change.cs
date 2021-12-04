using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace to_do_api.Models
{
    [Table("changes")]
    public class Change : TimestampedEntity
    {
        public Change() {}

        public Change(
            int taskId,
            int changingUserId,
            int listId,
            string value)
        {
            this.SetDateToNow();
            this.TaskId = taskId;
            this.ChangingUserId = changingUserId;
            this.ListId = listId;
            this.Value = value;
        }

        public int TaskId { get; set; }

        [ForeignKey("TaskId")]
        public ToDoTask Task { get; set; }

        public int ChangingUserId { get; set; }

        [ForeignKey("ChangingUserId")]
        public User ChangingUser { get; set; }

        public int ListId { get; set; }

        [ForeignKey("ListId")]
        public ToDoList List { get; set; }
        
        public string Value { get; set; }
    }
}
