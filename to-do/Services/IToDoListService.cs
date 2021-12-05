using System;
using to_do.Services.@abstract;
using to_do.DTOs;
namespace to_do.Services
{
    public interface IToDoListService : IAbstractCreateReadUpdateService<
        ToDoListDTO.ToDoListResponse,
        ToDoListDTO.ToDoListCreateRequest,
        ToDoListDTO.ToDoListUpdateRequest>
    {
    }
}
