using System;
using System.Net.Http;
using to_do.Services.@abstract;
using to_do.DTOs;
namespace to_do.Services.impl
{
    public class ToDoTaskService : AbstractCreateReadUpdateService<
        ToDoTaskDTO.ToDoTaskResponse,
        ToDoTaskDTO.ToDoTaskCreateRequest,
        ToDoTaskDTO.ToDoTaskUpdateRequest>,
        IToDoTaskService
    {
        public ToDoTaskService(HttpClient http)
            : base(http, APIResource.LOCALHOST, APIResource.TASKS) {}
    }
}
