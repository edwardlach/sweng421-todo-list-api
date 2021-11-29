using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace to_do_api.Models
{
    [Table("assignments")]
    public class Assignment : TimestampedEntity
    {
        public Boolean Deleted { get; set; }

        public int TaskId { get; set; }

        [ForeignKey("TaskId")]
        public ToDoTask Task { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
