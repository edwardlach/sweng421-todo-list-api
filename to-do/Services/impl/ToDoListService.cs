using System;
using System.Net.Http;
using to_do.Services.@abstract;
using to_do.DTOs;
namespace to_do.Services.impl
{
    public class ToDoListService : AbstractCreateReadUpdateService<
        ToDoListDTO.ToDoListResponse,
        ToDoListDTO.ToDoListCreateRequest,
        ToDoListDTO.ToDoListUpdateRequest>,
        IToDoListService
    {
        public ToDoListService(HttpClient http)
            : base(http, APIResource.LOCALHOST, APIResource.LISTS) {}
    }
}
