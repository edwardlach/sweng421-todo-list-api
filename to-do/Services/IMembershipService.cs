using System;
using to_do.Services.@abstract;
using to_do.DTOs;
namespace to_do.Services
{
    public interface IMembershipService : IAbstractCreateReadUpdateService<
        MembershipDTO.MembershipResponse,
        MembershipDTO.MembershipCreateRequest,
        MembershipDTO.MembershipUpdateRequest>
    {
    }
}
