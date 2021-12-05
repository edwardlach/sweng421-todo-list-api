using System;
using System.Net.Http;
using to_do.Services.@abstract;
using to_do.DTOs;
namespace to_do.Services.impl
{
    public class AsssignmentService : AbstractCreateReadUpdateService<
        AssignmentDTO.AssignmentResponse,
        AssignmentDTO.AssignmentCreateRequest,
        AssignmentDTO.AssignmentUpdateRequest>,
        IAssignmentService
    {
        public AsssignmentService(
            HttpClient http,
            string host) : base(http, host, APIResource.ASSIGNMENTS) {}
    }
}
