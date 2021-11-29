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
    public class MembershipsController : ControllerBase
    {
        private readonly IMembershipService membershipService;

        public MembershipsController(IMembershipService membershipService)
        {
            this.membershipService = membershipService;
        }

        // POST memberships
        [HttpPost]
        public MembershipDTO.MembershipResponse Post(MembershipDTO.MembershipCreateRequest toCreate)
        {
            return new MembershipDTO.MembershipResponse(
                this.membershipService.Create(toCreate.ToModel()));
        }

        // GET memberships/{id}
        [HttpGet("{id}")]
        public MembershipDTO.MembershipResponse Get(int id)
        {
            return new MembershipDTO.MembershipResponse(this.membershipService.Read(id));
        }

        // PUT memberships/{id}
        [HttpPut("{id}")]
        public MembershipDTO.MembershipResponse Put(int id, MembershipDTO.MembershipUpdateRequest updates)
        {
            return new MembershipDTO.MembershipResponse(
                this.membershipService.Update(id, updates.ToModel()));
        }
    }
}
