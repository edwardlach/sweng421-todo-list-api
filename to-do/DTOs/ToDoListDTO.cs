using System;
using to_do.DTOs.@abstract;
namespace to_do.DTOs
{
    public class ToDoListDTO
    {
        public class ToDoListCreateRequest
        {
            public string Name { get; set; }

            public int CreatorId { get; set; }
        }

        public class ToDoListResponse : AbstractTimestampedDTO.AbstractTimestampedResponse
        {
            public string Name { get; set; }

            public UserDTO.UserResponse Creator { get; set; }

            public ToDoTaskDTO.ToDoTaskCollectionResponse Tasks { get; set; }

            public MembershipDTO.MembershipCollectionResponse Memberships { get; set; }
        }

        public class ToDoListSummaryResponse : AbstractTimestampedDTO.AbstractTimestampedResponse
        {
            public string Name { get; set; }

            public UserDTO.UserResponse Creator { get; set; }
        }

        public class ToDoListUpdateRequest : AbstractIdentifiableDTO.AbstractIdentifiableUpdateRequest
        {
            public string Name { get; set; }
        }
    }
}
