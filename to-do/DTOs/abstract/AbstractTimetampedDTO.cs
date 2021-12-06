using System;
namespace to_do.DTOs.@abstract
{
    public class AbstractTimestampedDTO
    {
        public abstract class AbstractTimestampedResponse
            : AbstractIdentifiableDTO.AbstractIdentifiableResponse
        {
            public DateTime CreatedDate { get; set; }
            public DateTime UpdatedDate { get; set; }
        }
    }
}
