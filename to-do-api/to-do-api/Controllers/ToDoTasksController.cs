using System;
using Microsoft.AspNetCore.Mvc;
using to_do_api.Services;
using to_do_api.DTOs;
namespace to_do_api.Controllers
{
    [ApiController]
    [Route("tasks")]
    public class ToDoTasksController : ControllerBase
    {
        private readonly IToDoTaskService taskService;

        public ToDoTasksController(IToDoTaskService taskService) 
        {
            this.taskService = taskService;
        }

        // POST tasks
        [HttpPost]
        public ToDoTaskDTO.ToDoTaskResponse Post(ToDoTaskDTO.ToDoTaskCreateRequest toCreate)
        {
            return new ToDoTaskDTO.ToDoTaskResponse(
                this.taskService.Create(toCreate.ToModel()));
        }

        // GET tasks/{id}
        [HttpGet("{id}")]
        public ToDoTaskDTO.ToDoTaskResponse GET(int id)
        {
            return new ToDoTaskDTO.ToDoTaskResponse(this.taskService.Read(id));
        }

    }
}
