using System;
using to_do_api.DAOs;
using to_do_api.Models;
using to_do_api.DAOs.impl.@abstract;
using System.Linq;
namespace to_do_api.DAOs.impl
{
    public class UserDAOImpl : AbstractCreateReadUpdateDAO<User>, IUserDAO
    {
        public UserDAOImpl(ToDoContext dbContext) : base(dbContext) {}

        public User GetUserByEmail(string email)
        {
            return dbContext.Users
                .Where(u => u.Email == email)
                .FirstOrDefault();
        }

        protected override void ApplyUpdates(User toUpdate, User updates)
        {
            if (updates.FirstName != null)
            {
                toUpdate.FirstName = updates.FirstName;
            }

            if (updates.LastName != null)
            {
                toUpdate.LastName = updates.LastName;
            }

            if (updates.Email != null)
            {
                toUpdate.Email = updates.Email;
            }
        }
    }
}
