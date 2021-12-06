using System;
using to_do.DTOs.@abstract;
namespace to_do.DTOs
{
    public class MembershipDTO
    {
        public class MembershipCreateRequest
        {
            public int ListId { get; set; }

            public int UserId { get; set; }
        }

        public class MembershipResponse : AbstractTimestampedDTO.AbstractTimestampedResponse
        {
            public Boolean Deleted { get; set; }

            public ToDoListDTO.ToDoListResponse List { get; set; }

            public UserDTO.UserResponse User { get; set; }
        }

        public class MemberResponse : AbstractTimestampedDTO.AbstractTimestampedResponse
        {
            public Boolean Deleted { get; set; }

            public UserDTO.UserResponse User { get; set; }
        }

        public class MembershipCollectionResponse
            : AbstractCollectionDTO.AbstractCollectionResponse<MemberResponse>
        {
        }

        public class MembershipUpdateRequest : AbstractIdentifiableDTO.AbstractIdentifiableUpdateRequest
        {
            public Boolean Deleted { get; set; }
        }
    }
}
