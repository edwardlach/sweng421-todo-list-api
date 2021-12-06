using System;
using to_do.Services.@abstract;
using to_do.DTOs;
using System.Threading.Tasks;
namespace to_do.Services
{
    public interface IUserService : IAbstractCreateReadUpdateService<
        UserDTO.UserResponse,
        UserDTO.UserCreateRequest,
        UserDTO.UserUpdateRequest>
    {
        Task<SubscriptionDTO.SubscriptionCollectionResponse> GetUserSubscriptions(int userId);
    }
}
