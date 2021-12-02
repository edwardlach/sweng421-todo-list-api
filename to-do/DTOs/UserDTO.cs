using System;
using to_do.DTOs.@abstract;
namespace to_do.DTOs
{
    public class UserDTO
    {
        public class UserCreateRequest
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Email { get; set; }

            public string Password { get; set; }
        }

        public class UserResponse : AbstractTimestampedDTO.AbstractTimestampedResponse
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Email { get; set; }
        }

        public class UserUpdateRequest : AbstractIdentifiableDTO.AbstractIdentifiableUpdateRequest
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Email { get; set; }
        }
    }
}
