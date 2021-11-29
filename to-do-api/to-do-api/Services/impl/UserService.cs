using System;
using to_do_api.Services;
using to_do_api.Services.impl.@abstract;
using to_do_api.Models;
using to_do_api.DAOs.@abstract;
using to_do_api.DAOs;

namespace to_do_api.Services.impl
{
    public class UserService : AbstractCreateReadUpdateService<User>, IUserService
    {
        new protected IUserDAO dao;

        public UserService(IUserDAO dao) : base(dao)
        {
            this.dao = dao;
        }

        public User GetUserByEmail(string email)
        {
            return this.dao.GetUserByEmail(email);
        }
    }
}
