using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace to_do_api.Models
{
    [Table("memberships")]
    public class Membership : TimestampedEntity
    {
        public Membership() {}

        public Membership(int userId, int listId)
        {
            this.SetDateToNow();
            this.Deleted = false;
            this.UserId = userId;
            this.ListId = listId;
        }

        public Boolean Deleted { get; set; }

        public int ListId { get; set; }

        [ForeignKey("ListId")]
        public ToDoList List { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
