using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using to_do_api.DTOs;
using to_do_api.Services;
namespace to_do_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssignmentsController : Controller
    {
        private readonly IAssignmentService assignmentService;

        public AssignmentsController(IAssignmentService assignmentService)
        {
            this.assignmentService = assignmentService;
        }

        // POST assignments
        [HttpPost]
        public AssignmentDTO.AssignmentResponse Post(AssignmentDTO.AssignmentCreateRequest toCreate)
        {
            return new AssignmentDTO.AssignmentResponse(
                this.assignmentService.Create(toCreate.ToModel()));
        }

        // GET assignments/{id}
        [HttpGet("{id}")]
        public AssignmentDTO.AssignmentResponse Get(int id)
        {
            return new AssignmentDTO.AssignmentResponse(this.assignmentService.Read(id));
        }

        // PUT assignments/{id}
        [HttpPut("{id}")]
        public AssignmentDTO.AssignmentResponse Put(int id, AssignmentDTO.AssignmentUpdateRequest updates)
        {
            return new AssignmentDTO.AssignmentResponse(
                this.assignmentService.Update(id, updates.ToModel()));
        }
    }
}
