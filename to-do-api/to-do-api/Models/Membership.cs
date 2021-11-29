using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace to_do_api.Models
{
    [Table("memberships")]
    public class Membership : TimestampedEntity
    {
        public Boolean Deleted { get; set; }

        public int ListId { get; set; }

        [ForeignKey("ListId")]
        public ToDoList List { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
