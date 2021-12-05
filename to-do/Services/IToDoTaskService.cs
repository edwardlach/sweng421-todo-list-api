using System;
using to_do.Services.@abstract;
using to_do.DTOs;
namespace to_do.Services
{
    public interface IToDoTaskService : IAbstractCreateReadUpdateService<
        ToDoTaskDTO.ToDoTaskResponse,
        ToDoTaskDTO.ToDoTaskCreateRequest,
        ToDoTaskDTO.ToDoTaskUpdateRequest>
    {
    }
}
