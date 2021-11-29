using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using to_do_api.Models;
using to_do_api.DAOs.impl.@abstract;
namespace to_do_api.DAOs.impl
{
    public class AssignmentDAOImpl : AbstractCreateReadUpdateDAO<Assignment>, IAssignmentDAO
    {
        public AssignmentDAOImpl(ToDoContext dbContext) : base(dbContext) {}

        public List<Assignment> ReadByUser(int id)
        {
            return dbContext.Assignments
                .Include<Assignment>("Task")
                .Where<Assignment>(a => a.UserId == id)
                .ToList();
        }

        protected override void ApplyUpdates(Assignment toUpdate, Assignment updates)
        {
            if (toUpdate.Deleted != updates.Deleted)
            {
                toUpdate.Deleted = updates.Deleted;
            }
        }
    }
}
