using System;
using to_do_api.Services.impl.@abstract;
using to_do_api.Models;
using to_do_api.DAOs.@abstract;
using to_do_api.DAOs;
namespace to_do_api.Services.impl
{
    public class ToDoListService : AbstractCreateReadUpdateService<ToDoList>, IToDoListService
    {
        new protected IToDoListDAO dao;
        private IUserService userService;
        private IMembershipService membershipService;

        public ToDoListService(
            IToDoListDAO dao,
            IUserService userService,
            IMembershipService membershipService) : base(dao)
        {
            this.dao = dao;
            this.userService = userService;
            this.membershipService = membershipService;
        }

        new public ToDoList Create(ToDoList toCreate)
        {
            ToDoList toDoList = base.Create(toCreate);
            Membership membership = new Membership(toCreate.CreatorId, toDoList.Id);
            this.membershipService.Create(membership);
            return toDoList;
        }

        new public ToDoList Read(int id)
        {
            ToDoList list = base.Read(id);
            list.Creator = userService.Read(list.CreatorId);
            return list;
        }
    }
}
