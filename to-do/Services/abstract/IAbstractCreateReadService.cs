using System;
using System.Threading.Tasks;
using to_do.DTOs.@abstract;
namespace to_do.Services.@abstract
{
    public interface IAbstractCreateReadService<RESPONSE, CREATE_REQUEST>
        : IAbstractReadService<RESPONSE>
        where RESPONSE : AbstractIdentifiableDTO.AbstractIdentifiableResponse
    {
        Task<RESPONSE> Create(CREATE_REQUEST request);
    }
}
