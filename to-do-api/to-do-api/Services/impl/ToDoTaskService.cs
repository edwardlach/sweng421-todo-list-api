using System;
using to_do_api.Services.impl.@abstract;
using to_do_api.Models;
using to_do_api.DAOs;
using to_do_api.Enums;
using System.Collections.Generic;

namespace to_do_api.Services.impl
{
    public class ToDoTaskService : AbstractCreateReadUpdateService<ToDoTask>, IToDoTaskService
    {
        new protected IToDoTaskDAO dao;
        private IToDoListService listService;
        private IChangeService changeService;

        public ToDoTaskService(
            IToDoTaskDAO dao,
            IToDoListService listService,
            IChangeService changeService) : base(dao)
        {
            this.dao = dao;
            this.listService = listService;
            this.changeService = changeService;
        }

        public ToDoTask Create(ToDoTask toDoTask, int userId)
        {
            ToDoTask task = base.Create(toDoTask);
            this.CreateChange(task, userId, ChangeValue.CREATED);
            task.List = this.listService.Read(task.ListId);
            return task;
        }

        new public ToDoTask Read(int id)
        {
            ToDoTask task = this.dao.Read(id);
            task.List = this.listService.Read(task.ListId);
            return task;
        }

        public List<ToDoTask> ReadByListId(int listId)
        {
            return this.dao.GetTasksByListId(listId);
        }

        public ToDoTask Update(int id, ToDoTask toDoTask, int userId)
        {
            ToDoTask task = base.Update(id, toDoTask);
            this.CreateChange(task, userId, ChangeValue.UPDATED);
            return task;
        }

        private void CreateChange(
            ToDoTask task,
            int userId,
            ChangeValue changeValue)
        {
            changeService.Create(new Change(
                task.Id,
                userId,
                task.ListId,
                changeValue.ToString()));
        }
    }
}
