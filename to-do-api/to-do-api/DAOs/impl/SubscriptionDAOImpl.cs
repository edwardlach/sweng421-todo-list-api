using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using to_do_api.Models;
using to_do_api.DAOs.impl.@abstract;
namespace to_do_api.DAOs.impl
{
    public class SubscriptionDAOImpl : AbstractCreateReadUpdateDAO<Subscription>, ISubscriptionDAO
    {
        public SubscriptionDAOImpl(ToDoContext dbContext) : base(dbContext) {}

        protected override void ApplyUpdates(Subscription toUpdate, Subscription updates)
        {
            toUpdate.LastAccessed = updates.LastAccessed;
            toUpdate.Deleted = updates.Deleted;
        }
    }
}
