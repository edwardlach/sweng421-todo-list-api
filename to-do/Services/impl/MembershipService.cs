using System;
using System.Net.Http;
using to_do.Services.@abstract;
using to_do.DTOs;
namespace to_do.Services.impl
{
    public class MembershipService : AbstractCreateReadUpdateService<
        MembershipDTO.MembershipResponse,
        MembershipDTO.MembershipCreateRequest,
        MembershipDTO.MembershipUpdateRequest>,
        IMembershipService
    {
        public MembershipService(HttpClient http)
            : base(http, APIResource.LOCALHOST, APIResource.MEMBERSHIPS) {}
    }
}
