using System;
using to_do.DTOs.@abstract;
namespace to_do.DTOs
{
    public class AssignmentDTO
    {
        public class AssignmentCreateRequest
        {
            public Boolean Deleted { get; set; }

            public int TaskId { get; set; }

            public int UserId { get; set; }
        }

        public class AssignmentResponse : AbstractTimestampedDTO.AbstractTimestampedResponse
        {
            public Boolean Deleted { get; set; }

            public ToDoTaskDTO.ToDoTaskResponse Task { get; set; }

            public UserDTO.UserResponse User { get; set; }
        }

        public class AssignmentCollectionResponse
            : AbstractCollectionDTO.AbstractCollectionResponse<AssignmentResponse>
        {
        }

        public class AssignmentUpdateRequest : AbstractIdentifiableDTO.AbstractIdentifiableUpdateRequest
        {
            public Boolean Deleted { get; set; }
        }
    }
}
