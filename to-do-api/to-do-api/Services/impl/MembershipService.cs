using System;
using to_do_api.Services.impl.@abstract;
using to_do_api.Models;
using to_do_api.DAOs;
namespace to_do_api.Services.impl
{
    public class MembershipService : AbstractCreateReadUpdateService<Membership>, IMembershipService
    {
        new protected IMembershipDAO dao;
        private IToDoListService listService;
        private IUserService userService;

        public MembershipService(
            IMembershipDAO dao,
            IToDoListService listService,
            IUserService userService) : base(dao)
        {
            this.dao = dao;
            this.listService = listService;
            this.userService = userService;
        }

        new public Membership Create(Membership toCreate)
        {
            Membership membership = base.Create(toCreate);
            membership.List = this.listService.Read(membership.ListId);
            membership.User = this.userService.Read(membership.UserId);
            return membership;
        }
    }
}
