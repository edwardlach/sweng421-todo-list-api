using System;
using to_do_api.Services.impl.@abstract;
using to_do_api.Models;
using to_do_api.DAOs;
namespace to_do_api.Services.impl
{
    public class ToDoTaskService : AbstractCreateReadUpdateService<ToDoTask>, IToDoTaskService
    {
        new protected IToDoTaskDAO dao;
        private IToDoListService listService;

        public ToDoTaskService(
            IToDoTaskDAO dao,
            IToDoListService listService) : base(dao)
        {
            this.dao = dao;
            this.listService = listService;
        }

        new public ToDoTask Create(ToDoTask toDoTask)
        {
            ToDoTask task = base.Create(toDoTask);
            task.ToDoList = this.listService.Read(task.ListId);
            return task;
        }

        new public ToDoTask Read(int id)
        {
            ToDoTask task = this.dao.Read(id);
            task.ToDoList = this.listService.Read(task.ListId);
            return task;
        }
    }
}
