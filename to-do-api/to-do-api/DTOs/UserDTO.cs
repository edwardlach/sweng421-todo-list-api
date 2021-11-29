using System;
using to_do_api.DTOs.@abstract;
using to_do_api.Models;
namespace to_do_api.DTOs
{
    public class UserDTO
    {
        public class UserCreateRequest : AbstractTimestampedDTO.AbstractTimestampedCreateRequest<User>
        {
            public override User ToModel()
            {
                User user = new User();
                base.ToModelHelper(user);
                user.FirstName = this.FirstName;
                user.LastName = this.LastName;
                user.Email = this.Email;
                user.Password = this.Password;
                return user;
            }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Email { get; set; }

            public string Password { get; set; }
        }

        public class UserResponse : AbstractTimestampedDTO.AbstractTimestampedResponse<User>
        {
            public UserResponse(User entity) : base(entity)
            {
                this.FirstName = entity.FirstName;
                this.LastName = entity.LastName;
                this.Email = entity.Email;
            }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Email { get; set; }
        }

        public class UserUpdateRequest : AbstractTimestampedDTO.AbstractTimestampedUpdateRequest<User>
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Email { get; set; }

            public override User ToModel()
            {
                User user = new User();
                base.ToModelHelper(user);
                user.FirstName = this.FirstName;
                user.LastName = this.LastName;
                user.Email = this.Email;
                return user;
            }
        }
    }
}
