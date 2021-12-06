using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace to_do_api.Models
{
    [Table("tasks")]
    public class ToDoTask : TimestampedEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Priority { get; set; }

        public string Status { get; set; }

        public DateTime DueDate { get; set; }

        public int ListId { get; set; }

        [ForeignKey("ListId")]
        public ToDoList List { get; set; }
    }
}
