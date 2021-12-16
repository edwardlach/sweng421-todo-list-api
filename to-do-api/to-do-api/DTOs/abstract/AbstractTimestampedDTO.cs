using System;
using to_do_api.Models;
namespace to_do_api.DTOs.@abstract
{
    public class AbstractTimestampedDTO
    {
        public abstract class AbstractTimestampedCreateRequest<MODEL>
            : AbstractIdentifiableDTO.AbstractIdentifiableCreateRequest<MODEL> where MODEL : TimestampedEntity
        {
            protected MODEL ToModelHelper(MODEL entity)
            {
                entity.CreatedDate = DateTime.UtcNow;
                entity.UpdatedDate = DateTime.UtcNow;
                return entity;
            }
        }

        public abstract class AbstractTimestampedResponse<MODEL>
            : AbstractIdentifiableDTO.AbstractIdentifiableResponse<MODEL> where MODEL : TimestampedEntity
        {
            protected AbstractTimestampedResponse(MODEL entity) : base(entity)
            {
                this.CreatedDate = entity.CreatedDate;
                this.UpdatedDate = entity.UpdatedDate;
            }

            public DateTime CreatedDate { get; set; }
            public DateTime UpdatedDate { get; set; }
        }

        public abstract class AbstractTimestampedUpdateRequest<MODEL>
             : AbstractIdentifiableDTO.AbstractIdentifiableUpdateRequest<MODEL> where MODEL : TimestampedEntity
        {
            new protected MODEL ToModelHelper(MODEL entity)
            {
                base.ToModelHelper(entity);
                entity.UpdatedDate = DateTime.UtcNow;
                return entity;
            }
        }
    }
}
