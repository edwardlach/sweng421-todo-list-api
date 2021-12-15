using System;
using System.Collections.Generic;
using to_do.DTOs.@abstract;
namespace to_do.DTOs
{
    public class ChangeDTO
    {
        public class ChangeResponse : AbstractTimestampedDTO.AbstractTimestampedResponse
        {
            public ToDoTaskDTO.ToDoTaskSummaryResponse Task { get; set; }

            public UserDTO.UserResponse ChangingUser { get; set; }

            public string Value { get; set; }
        }

        public class ChangeCollectionResponse : AbstractCollectionDTO.AbstractCollectionResponse<ChangeResponse>
        {
        }
    }
}
