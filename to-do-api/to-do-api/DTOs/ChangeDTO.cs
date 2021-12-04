using System;
using System.Collections.Generic;
using to_do_api.DTOs.@abstract;
using to_do_api.Models;
namespace to_do_api.DTOs
{
    public class ChangeDTO
    {
        public class ChangeResponse : AbstractTimestampedDTO.AbstractTimestampedResponse<Change>
        {
            public ChangeResponse(Change entity) : base(entity)
            {
                this.Task = new ToDoTaskDTO.ToDoTaskSummaryResponse(entity.Task);
                this.Value = entity.Value;
                this.ChangingUser = new UserDTO.UserResponse(entity.ChangingUser);
            }

            public ToDoTaskDTO.ToDoTaskSummaryResponse Task { get; set; }

            public UserDTO.UserResponse ChangingUser { get; set; }

            public string Value { get; set; }
        }

        public class ChangeCollectionResponse : AbstractCollectionDTO.AbstractCollectionResponse<Change, ChangeResponse>
        {
            public ChangeCollectionResponse(List<Change> entities) : base(entities) {}

            public override ChangeResponse ToResponse(Change entity)
            {
                return new ChangeResponse(entity);
            }
        }
    }
}
