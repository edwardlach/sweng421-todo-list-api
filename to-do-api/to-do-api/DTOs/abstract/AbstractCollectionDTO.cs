using System;
using System.Collections.Generic;
using to_do_api.Models;
using to_do_api.DTOs.@abstract;
namespace to_do_api.DTOs.@abstract
{
    public class AbstractCollectionDTO
    {
        public abstract class AbstractCollectionResponse <MODEL, RESPONSE>
            where MODEL : IdentifiableEntity
            where RESPONSE : AbstractIdentifiableDTO.AbstractIdentifiableResponse<MODEL>
        {
            public List<RESPONSE> Collection { get; set; }

            public AbstractCollectionResponse(List<MODEL> entities)
            {
                List<RESPONSE> collection = new List<RESPONSE>();
                entities.ForEach(e => collection.Add(ToResponse(e)));
                this.Collection = collection;
            }

            public abstract RESPONSE ToResponse(MODEL entity);
        }
    }
}
