using System;
using to_do_api.Models;
using to_do_api.DAOs.impl.@abstract;
namespace to_do_api.DAOs.impl
{
    public class MembershipDAOImpl : AbstractCreateReadUpdateDAO<Membership>, IMembershipDAO
    {
        public MembershipDAOImpl(ToDoContext dbContext) : base(dbContext) {}

        protected override void ApplyUpdates(Membership toUpdate, Membership updates)
        {
            if (updates.Deleted)
            {
                toUpdate.Deleted = updates.Deleted;
            }
        }
    }
}
