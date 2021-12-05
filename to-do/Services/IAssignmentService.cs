using System;
using to_do.Services.@abstract;
using to_do.DTOs;
namespace to_do.Services
{
    public interface IAssignmentService : IAbstractCreateReadUpdateService<
        AssignmentDTO.AssignmentResponse,
        AssignmentDTO.AssignmentCreateRequest,
        AssignmentDTO.AssignmentUpdateRequest>
    {
    }
}
