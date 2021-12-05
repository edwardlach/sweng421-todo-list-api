using System;
using System.Collections.Generic;
using to_do_api.Services.impl.@abstract;
using to_do_api.Models;
using to_do_api.DAOs;
namespace to_do_api.Services.impl
{
    public class SubscriptionService : AbstractCreateReadUpdateService<Subscription>, ISubscriptionService
    {
        new protected ISubscriptionDAO dao;
        private readonly IChangeService changeService;

        public SubscriptionService(
            ISubscriptionDAO dao,
            IChangeService changeService) : base(dao)
        {
            this.dao = dao;
            this.changeService = changeService;
        }

        public List<Change> ReadChangesForSubscription(int id)
        {
            Subscription subscription = this.Read(id);
            List<Change> changes = this.changeService.GetChangesForListSince(
                subscription.ListId, subscription.LastAccessed);
            subscription.LastAccessed = DateTime.Now;
            this.Update(subscription.Id, subscription);
            return changes;
        }

        public List<Subscription> ReadForUser(int userId)
        {
            return this.dao.ReadForUser(userId);
        }
    }
}
