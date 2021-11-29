using System;
using to_do_api.DTOs.@abstract;
using to_do_api.DTOs;
using to_do_api.Models;
using System.Linq;
namespace to_do_api.DTOs
{
    public class ToDoListDTO
    {
        public class ToDoListCreateRequest : AbstractTimestampedDTO.AbstractTimestampedCreateRequest<ToDoList>
        {
            public override ToDoList ToModel()
            {
                ToDoList list = new ToDoList();
                this.ToModelHelper(list);
                list.Name = this.Name;
                list.CreatorId = this.CreatorId;
                return list;
            }

            public string Name { get; set; }

            public int CreatorId { get; set; }
        }

        public class ToDoListResponse : AbstractTimestampedDTO.AbstractTimestampedResponse<ToDoList>
        {
            public ToDoListResponse(ToDoList entity) : base(entity)
            {
                this.Name = entity.Name;
                if (entity.Creator != null)
                {
                    this.Creator = new UserDTO.UserResponse(entity.Creator);
                }
                if (entity.Tasks != null)
                {
                    this.Tasks = new ToDoTaskDTO.ToDoTaskCollectionResponse(entity.Tasks.ToList());
                }
                if (entity.Memberships != null)
                {
                    this.Memberships = new MembershipDTO.MembershipCollectionResponse(entity.Memberships.ToList());
                }
            }

            public string Name { get; set; }

            public UserDTO.UserResponse Creator { get; set; }

            public ToDoTaskDTO.ToDoTaskCollectionResponse Tasks { get; set; }

            public MembershipDTO.MembershipCollectionResponse Memberships { get; set; }
        }

        public class ToDoListSummaryResponse : AbstractTimestampedDTO.AbstractTimestampedResponse<ToDoList>
        {
            public ToDoListSummaryResponse(ToDoList entity) : base(entity)
            {
                this.Name = entity.Name;
                if (entity.Creator != null)
                {
                    this.Creator = new UserDTO.UserResponse(entity.Creator);
                }
            }

            public string Name { get; set; }

            public UserDTO.UserResponse Creator { get; set; }
        }

        public class ToDoListUpdateRequest : AbstractTimestampedDTO.AbstractTimestampedUpdateRequest<ToDoList>
        {
            public string Name { get; set; }

            public override ToDoList ToModel()
            {
                ToDoList list = new ToDoList();
                this.ToModelHelper(list);
                list.Name = this.Name;
                return list;
            }
        }
    }
}
