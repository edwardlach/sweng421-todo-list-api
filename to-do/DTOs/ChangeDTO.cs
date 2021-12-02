using System;
using System.Collections.Generic;
using to_do.DTOs.@abstract;
namespace to_do.DTOs
{
    public class ChangeDTO
    {
        public class ChangeResponse : AbstractTimestampedDTO.AbstractTimestampedResponse
        {
            public int TaskId { get; set; }

            public string Field { get; set; }

            public string Value { get; set; }
        }

        public class ChangeCollectionResponse : AbstractCollectionDTO.AbstractCollectionResponse<ChangeResponse>
        {
            public ChangeCollectionResponse(List<ChangeResponse> changes) : base(changes) {}
        }
    }
}
