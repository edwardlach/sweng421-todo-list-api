using System;
using System.Net.Http;
using to_do.Services.@abstract;
using to_do.DTOs;
using System.Threading.Tasks;

namespace to_do.Services.impl
{
    public class UserService : AbstractCreateReadUpdateService<
        UserDTO.UserResponse,
        UserDTO.UserCreateRequest,
        UserDTO.UserUpdateRequest>,
        IUserService
    {
        public UserService(HttpClient http)
            : base(http, APIResource.LOCALHOST, APIResource.USERS) {}

        public async Task<SubscriptionDTO.SubscriptionCollectionResponse> GetUserSubscriptions(int userId)
        {
            HttpResponseMessage responseMessage = await http.GetAsync(
                host + resource + "/" + userId.ToString() + "/subscriptions");
            return await GetResponseFromMessage<SubscriptionDTO.SubscriptionCollectionResponse>(responseMessage);
        }
    }
}
