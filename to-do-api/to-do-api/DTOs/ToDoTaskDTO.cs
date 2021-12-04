using System;
using System.Collections.Generic;
using to_do_api.DTOs.@abstract;
using to_do_api.DTOs;
using to_do_api.Models;
using to_do_api.Enums;
namespace to_do_api.DTOs
{
    public class ToDoTaskDTO
    {
        public class ToDoTaskCreateRequest : AbstractTimestampedDTO.AbstractTimestampedCreateRequest<ToDoTask>
        {
            public string Title { get; set; }

            public string Description { get; set; }

            public string Priority { get; set; }

            public string Status { get; set; }

            public DateTime DueDate { get; set; }

            public int ListId { get; set; }

            public int UserId { get; set; }

            public override ToDoTask ToModel()
            {
                ToDoTask task = new ToDoTask();
                this.ToModelHelper(task);
                task.Title = this.Title;
                task.Description = this.Description;
                task.Priority = this.Priority;
                task.Status = this.Status;
                task.DueDate = this.DueDate;
                task.ListId = this.ListId;
                return task;
            }
        }

        public class ToDoTaskResponse : AbstractTimestampedDTO.AbstractTimestampedResponse<ToDoTask>
        {
            public ToDoTaskResponse(ToDoTask entity) : base(entity)
            {
                this.Title = entity.Title;
                this.Description = entity.Description;
                this.Priority = entity.Priority;
                this.Status = entity.Status;
                this.DueDate = entity.DueDate;
                if (entity.List != null)
                {
                    this.List = new ToDoListDTO.ToDoListSummaryResponse(entity.List);
                }
            }

            public string Title { get; set; }

            public string Description { get; set; }

            public string Priority { get; set; }

            public string Status { get; set; }

            public DateTime DueDate { get; set; }

            public ToDoListDTO.ToDoListSummaryResponse List { get; set; }
        }

        public class ToDoTaskSummaryResponse : AbstractTimestampedDTO.AbstractTimestampedResponse<ToDoTask>
        {
            public ToDoTaskSummaryResponse(ToDoTask entity) : base(entity)
            {
                this.Title = entity.Title;
                this.Description = entity.Description;
                this.Priority = entity.Priority;
                this.Status = entity.Status;
                this.DueDate = entity.DueDate;
                this.ListId = entity.ListId;
            }

            public string Title { get; set; }

            public string Description { get; set; }

            public string Priority { get; set; }

            public string Status { get; set; }

            public DateTime DueDate { get; set; }

            public int ListId { get; set; }
        }

        public class ToDoTaskCollectionResponse
            : AbstractCollectionDTO.AbstractCollectionResponse<ToDoTask, ToDoTaskSummaryResponse>
        {
            public ToDoTaskCollectionResponse(List<ToDoTask> entities) : base(entities) {}

            public override ToDoTaskSummaryResponse ToResponse(ToDoTask entity)
            {
                return new ToDoTaskSummaryResponse(entity);
            }
        }

        public class ToDoTaskUpdateRequest : AbstractTimestampedDTO.AbstractTimestampedUpdateRequest<ToDoTask>
        {
            public string Title { get; set; }

            public string Description { get; set; }

            public string Priority { get; set; }

            public string Status { get; set; }

            public DateTime DueDate { get; set; }

            public int UserId { get; set; }

            public override ToDoTask ToModel()
            {
                ToDoTask task = new ToDoTask();
                this.ToModelHelper(task);
                task.Title = this.Title;
                task.Description = this.Description;
                task.Priority = this.Priority;
                task.Status = this.Status;
                task.DueDate = this.DueDate;
                return task;
            }
        }
    }
}
