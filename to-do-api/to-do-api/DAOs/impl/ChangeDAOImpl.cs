using System;
using to_do_api.Models;
using to_do_api.DAOs.impl.@abstract;
namespace to_do_api.DAOs.impl
{
    public class ChangeDAOImpl : AbstractCreateReadDAO<Change>, IChangeDAO
    {
        public ChangeDAOImpl(ToDoContext dbContext) : base(dbContext) {}
    }
}
