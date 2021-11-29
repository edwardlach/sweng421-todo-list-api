using System;
using System.Collections.Generic;
using to_do_api.DTOs.@abstract;
using to_do_api.Models;
namespace to_do_api.DTOs
{
    public class AssignmentDTO
    {
        public class AssignmentCreateRequest : AbstractTimestampedDTO.AbstractTimestampedCreateRequest<Assignment>
        {
            public Boolean Deleted { get; set; }

            public int TaskId { get; set; }

            public int UserId { get; set; }

            public override Assignment ToModel()
            {
                Assignment assignment = new Assignment();
                ToModelHelper(assignment);
                assignment.Deleted = false;
                assignment.TaskId = this.TaskId;
                assignment.UserId = this.UserId;
                return assignment;
            }
        }

        public class AssignmentResponse : AbstractTimestampedDTO.AbstractTimestampedResponse<Assignment>
        {
            public AssignmentResponse(Assignment entity) : base(entity)
            {
                this.Deleted = entity.Deleted;
                if (entity.Task != null)
                {
                    this.Task = new ToDoTaskDTO.ToDoTaskResponse(entity.Task);
                }
                if (entity.User != null)
                {
                    this.User = new UserDTO.UserResponse(entity.User);
                }
            }

            public Boolean Deleted { get; set; }

            public ToDoTaskDTO.ToDoTaskResponse Task { get; set; }

            public UserDTO.UserResponse User { get; set; }
        }

        public class AssignmentCollectionResponse
            : AbstractCollectionDTO.AbstractCollectionResponse<Assignment, AssignmentResponse>
        {
            public AssignmentCollectionResponse(List<Assignment> entities) : base(entities) {} 

            public override AssignmentResponse ToResponse(Assignment entity)
            {
                return new AssignmentResponse(entity);
            }
        }

        public class AssignmentUpdateRequest : AbstractTimestampedDTO.AbstractTimestampedUpdateRequest<Assignment>
        {
            public Boolean Deleted { get; set; }

            public override Assignment ToModel()
            {
                Assignment assignment = new Assignment();
                ToModelHelper(assignment);
                assignment.Deleted = false;
                return assignment;
            }
        }
    }
}
