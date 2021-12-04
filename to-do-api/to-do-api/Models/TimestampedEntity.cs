using System;
namespace to_do_api.Models
{
    public class TimestampedEntity : IdentifiableEntity
    {
        public TimestampedEntity() {}
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public void SetDateToNow()
        {
            this.CreatedDate = DateTime.Now;
            this.UpdatedDate = DateTime.Now;
        }
    }
}
