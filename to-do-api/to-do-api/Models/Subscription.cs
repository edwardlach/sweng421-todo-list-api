using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace to_do_api.Models
{
    [Table("subscriptions")]
    public class Subscription : TimestampedEntity
    {
        public Subscription() {}

        public Subscription(int userId, int listId)
        {
            this.SetDateToNow();
            this.Deleted = false;
            this.LastAccessed = DateTime.UtcNow;
            this.UserId = userId;
            this.ListId = listId;
        }

        public Boolean Deleted { get; set; }

        public DateTime LastAccessed { get; set; }

        public int ListId { get; set; }

        [ForeignKey("ListId")]
        public ToDoList List { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
