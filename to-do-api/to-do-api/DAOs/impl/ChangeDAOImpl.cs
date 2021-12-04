using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using to_do_api.Models;
using to_do_api.DAOs.impl.@abstract;
namespace to_do_api.DAOs.impl
{
    public class ChangeDAOImpl : AbstractCreateReadDAO<Change>, IChangeDAO
    {
        public ChangeDAOImpl(ToDoContext dbContext) : base(dbContext) {}

        public List<Change> GetChangesByListIdSince(int listId, DateTime since)
        {
            return this.dbContext.Changes
                .Include<Change>("Task")
                .Include<Change>("ChangingUser")
                .Where<Change>(c => c.ListId == listId)
                .Where<Change>(c => c.UpdatedDate >= since)
                .ToList();
        }
    }
}
