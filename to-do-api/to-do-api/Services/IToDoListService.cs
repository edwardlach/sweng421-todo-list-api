using System;
using to_do_api.Services.@abstract;
using to_do_api.Models;
namespace to_do_api.Services
{
    public interface IToDoListService : ICreateReadUpdateService<ToDoList>
    {
    }
}
