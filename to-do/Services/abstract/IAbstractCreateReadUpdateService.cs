using System;
using System.Threading.Tasks;
using to_do.DTOs.@abstract;
namespace to_do.Services.@abstract
{
    public interface IAbstractCreateReadUpdateService<RESPONSE, CREATE_REQUEST, UPDATE_REQUEST>
        : IAbstractCreateReadService<RESPONSE, CREATE_REQUEST>
        where RESPONSE : AbstractIdentifiableDTO.AbstractIdentifiableResponse
    {
        Task<RESPONSE> Update(UPDATE_REQUEST updates, int id);
    }
}
