using System;
using System.Net.Http;
using to_do.Services.@abstract;
using to_do.DTOs;
namespace to_do.Services.impl
{
    public class UserService : AbstractCreateReadUpdateService<
        UserDTO.UserResponse,
        UserDTO.UserCreateRequest,
        UserDTO.UserUpdateRequest>,
        IUserService
    {
        public UserService(
            HttpClient http,
            string host) : base(http, host, APIResource.USERS) {}
    }
}
