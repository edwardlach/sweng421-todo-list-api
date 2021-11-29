using System;
using to_do_api.Services.@abstract;
using to_do_api.Models;
namespace to_do_api.Services
{
    public interface IUserService : ICreateReadUpdateService <User>
    {
        User GetUserByEmail(string email);
    }
}
