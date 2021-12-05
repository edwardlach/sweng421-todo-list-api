using System;
using System.Collections.Generic;
namespace to_do.DTOs.@abstract
{
    public class AbstractCollectionDTO
    {
        public abstract class AbstractCollectionResponse<RESPONSE>
            where RESPONSE : AbstractIdentifiableDTO.AbstractIdentifiableResponse
        {
            public List<RESPONSE> Collection { get; set; }
        }
    }
}
