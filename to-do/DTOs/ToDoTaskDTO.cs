using System;
using to_do.DTOs.@abstract;
namespace to_do.DTOs
{
    public class ToDoTaskDTO
    {
        public class ToDoTaskCreateRequest
        {
            public string Title { get; set; }

            public string Description { get; set; }

            public string Priority { get; set; }

            public string Status { get; set; }

            public DateTime DueDate { get; set; }

            public int ListId { get; set; }

            public int UserId { get; set; }
        }

        public class ToDoTaskResponse : AbstractTimestampedDTO.AbstractTimestampedResponse
        {
            public string Title { get; set; }

            public string Description { get; set; }

            public string Priority { get; set; }

            public string Status { get; set; }

            public DateTime DueDate { get; set; }

            public ToDoListDTO.ToDoListSummaryResponse List { get; set; }
        }

        public class ToDoTaskSummaryResponse : AbstractTimestampedDTO.AbstractTimestampedResponse
        {
            public string Title { get; set; }

            public string Description { get; set; }

            public string Priority { get; set; }

            public string Status { get; set; }

            public DateTime DueDate { get; set; }

            public int ListId { get; set; }
        }

        public class ToDoTaskCollectionResponse
            : AbstractCollectionDTO.AbstractCollectionResponse<ToDoTaskSummaryResponse>
        {
        }

        public class ToDoTaskUpdateRequest : AbstractIdentifiableDTO.AbstractIdentifiableUpdateRequest
        {
            public string Title { get; set; }

            public string Description { get; set; }

            public string Priority { get; set; }

            public string Status { get; set; }

            public DateTime DueDate { get; set; }

            public int UserId { get; set; }
        }
    }
}
