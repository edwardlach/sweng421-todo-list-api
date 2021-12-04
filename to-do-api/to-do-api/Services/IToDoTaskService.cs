using System;
using System.Collections.Generic;
using to_do_api.Services.@abstract;
using to_do_api.Models;
namespace to_do_api.Services
{
    public interface IToDoTaskService : ICreateReadUpdateService<ToDoTask>
    {
        ToDoTask Create(ToDoTask toDoTask, int userId);
        List<ToDoTask> ReadByListId(int listId);
        ToDoTask Update(int id, ToDoTask toDoTask, int userId);
    }
}
