using System;
using System.Collections.Generic;
using to_do_api.DAOs.@abstract;
using to_do_api.Models;
namespace to_do_api.DAOs
{
    public interface IToDoTaskDAO : IAbstractCreateReadUpdateDAO<ToDoTask>
    {
        List<ToDoTask> GetTasksByListId(int listId);
    }
}
