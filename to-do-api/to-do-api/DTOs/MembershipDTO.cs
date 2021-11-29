using System;
using System.Collections.Generic;
using to_do_api.DTOs.@abstract;
using to_do_api.Models;
namespace to_do_api.DTOs
{
    public class MembershipDTO
    {
        public class MembershipCreateRequest : AbstractTimestampedDTO.AbstractTimestampedCreateRequest<Membership>
        {
            public int ListId { get; set; }

            public int UserId { get; set; }

            public override Membership ToModel()
            {
                Membership membership = new Membership();
                ToModelHelper(membership);
                membership.ListId = this.ListId;
                membership.UserId = this.UserId;
                return membership;
            }
        }

        public class MembershipResponse : AbstractTimestampedDTO.AbstractTimestampedResponse<Membership>
        {
            public MembershipResponse(Membership entity) : base(entity)
            {
                this.Deleted = entity.Deleted;
                if (entity.List != null)
                {
                    this.List = new ToDoListDTO.ToDoListResponse(entity.List);
                }
                if (entity.User != null) {
                    this.User = new UserDTO.UserResponse(entity.User);
                }               
            }

            public Boolean Deleted { get; set; }

            public ToDoListDTO.ToDoListResponse List { get; set; }

            public UserDTO.UserResponse User { get; set; }
        }

        public class MemberResponse : AbstractTimestampedDTO.AbstractTimestampedResponse<Membership>
        {
            public MemberResponse(Membership entity) : base(entity)
            {
                this.Deleted = entity.Deleted;
                if (entity.User != null)
                {
                    this.User = new UserDTO.UserResponse(entity.User);
                }
            }

            public Boolean Deleted { get; set; }

            public UserDTO.UserResponse User { get; set; }
        }

        public class MembershipCollectionResponse
            : AbstractCollectionDTO.AbstractCollectionResponse<Membership, MemberResponse>
        {
            public MembershipCollectionResponse(List<Membership> entities) : base(entities) {}

            public override MemberResponse ToResponse(Membership entity)
            {
                return new MemberResponse(entity);
            }
        }

        public class MembershipUpdateRequest : AbstractTimestampedDTO.AbstractTimestampedUpdateRequest<Membership>
        {
            public Boolean Deleted { get; set; }

            public override Membership ToModel()
            {
                Membership membership = new Membership();
                ToModelHelper(membership);
                membership.Deleted = this.Deleted;
                return membership;
            }
        }
    }
}
