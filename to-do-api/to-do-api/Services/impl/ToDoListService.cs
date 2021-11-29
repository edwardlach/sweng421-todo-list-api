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

        public ToDoListService(
            IToDoListDAO dao,
            IUserService userService) : base(dao)
        {
            this.dao = dao;
            this.userService = userService;
        }

        new public ToDoList Read(int id)
        {
            ToDoList list = base.Read(id);
            list.Creator = userService.Read(list.CreatorId);
            return list;
        }
    }
}
