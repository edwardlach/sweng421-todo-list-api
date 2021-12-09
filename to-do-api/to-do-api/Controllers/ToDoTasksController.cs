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
        public ToDoTaskDTO.ToDoTaskResponse Create(ToDoTaskDTO.ToDoTaskCreateRequest toCreate)
        {
            return new ToDoTaskDTO.ToDoTaskResponse(
                this.taskService.Create(toCreate.ToModel(), toCreate.UserId));
        }

        // GET tasks/{id}
        [HttpGet("{id}")]
        public ToDoTaskDTO.ToDoTaskResponse Read(int id)
        {
            return new ToDoTaskDTO.ToDoTaskResponse(this.taskService.Read(id));
        }

        // PUT tasks/{id}
        
        [HttpPut("{id}")]
        public ToDoTaskDTO.ToDoTaskResponse Update(int id, ToDoTaskDTO.ToDoTaskUpdateRequest updates)
        {
            return new ToDoTaskDTO.ToDoTaskResponse(
                this.taskService.Update(id, updates.ToModel(), updates.UserId));
        }
    }
}
