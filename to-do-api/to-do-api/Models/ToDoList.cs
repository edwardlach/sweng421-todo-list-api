using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace to_do_api.Models
{
    [Table("lists")]
    public class ToDoList : TimestampedEntity
    {
        public string Name { get; set; }

        public int CreatorId { get; set; }

        [ForeignKey("CreatorId")]
        public User Creator { get; set; }

        public ICollection<ToDoTask> Tasks { get; set; }

        public ICollection<Membership> Memberships { get; set; }
    }
}
