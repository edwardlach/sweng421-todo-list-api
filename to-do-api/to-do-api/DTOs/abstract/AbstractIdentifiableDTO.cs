using System;
using to_do_api.Models;
namespace to_do_api.DTOs.@abstract
{
    public class AbstractIdentifiableDTO
    {
        public abstract class AbstractIdentifiableCreateRequest<MODEL> where MODEL : IdentifiableEntity
        {
            public abstract MODEL ToModel();
        }

        public abstract class AbstractIdentifiableResponse<MODEL> where MODEL : IdentifiableEntity
        {
            protected AbstractIdentifiableResponse(MODEL entity)
            {
                this.Id = entity.Id;    
            }

            public int Id { get; set; }
        }    

        public abstract class AbstractIdentifiableUpdateRequest<MODEL> where MODEL : IdentifiableEntity
        {
            public int Id { get; set; }

            protected MODEL ToModelHelper(MODEL entity)
            {
                entity.Id = this.Id;
                return entity;
            }

            public abstract MODEL ToModel();
        }
    }
}
