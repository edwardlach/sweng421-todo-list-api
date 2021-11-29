using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace to_do_api.Models
{
    [Table("changes")]
    public class Change : TimestampedEntity
    {
        public int TaskId { get; set; }

        [ForeignKey("TaskId")]
        public ToDoTask Task { get; set; }

        public string Field { get; set; }
        
        public string Value { get; set; }
    }
}
