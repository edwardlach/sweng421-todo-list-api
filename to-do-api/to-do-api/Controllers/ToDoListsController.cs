using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using to_do_api.Services;
using to_do_api.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace to_do_api.Controllers
{
    [ApiController]
    [Route("lists")]
    public class ToDoListsController : ControllerBase
    {
        private readonly IToDoListService listService;

        public ToDoListsController(IToDoListService listService)
        {
            this.listService = listService;
        }

        // POST toDoLists
        [HttpPost]
        public ToDoListDTO.ToDoListResponse Post(ToDoListDTO.ToDoListCreateRequest toCreate)
        {
            return new ToDoListDTO.ToDoListResponse(
                this.listService.Create(toCreate.ToModel()));
        }

        // GET toDoLists/{id}
        [HttpGet("{id}")]
        public ToDoListDTO.ToDoListResponse Get(int id)
        {
            return new ToDoListDTO.ToDoListResponse(this.listService.Read(id));
        }

        // PUT toDoLists/{id}
        [HttpPut("{id}")]
        public ToDoListDTO.ToDoListResponse Put(int id, ToDoListDTO.ToDoListUpdateRequest updates)
        {
            return new ToDoListDTO.ToDoListResponse(
                this.listService.Update(id, updates.ToModel()));
        }
    }
}
