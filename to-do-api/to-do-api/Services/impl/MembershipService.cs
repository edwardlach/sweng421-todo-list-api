using System;
using to_do_api.Services.impl.@abstract;
using to_do_api.Models;
using to_do_api.DAOs;
namespace to_do_api.Services.impl
{
    public class MembershipService : AbstractCreateReadUpdateService<Membership>, IMembershipService
    {
        new protected IMembershipDAO dao;
        private ISubscriptionService subscriptionService;

        public MembershipService(
            IMembershipDAO dao,
            ISubscriptionService subscriptionService) : base(dao)
        {
            this.dao = dao;
            this.subscriptionService = subscriptionService;
        }

        new public Membership Create(Membership toCreate)
        {
            Membership membership = base.Create(toCreate);
            this.subscriptionService.Create(
                new Subscription(membership.UserId, membership.ListId));
            return membership;
        }
    }
}
