using System;
using System.Threading.Tasks;
using to_do.DTOs.@abstract;
namespace to_do.Services.@abstract
{
    public interface IAbstractReadService<RESPONSE>
        where RESPONSE : AbstractIdentifiableDTO.AbstractIdentifiableResponse
    {
        Task<RESPONSE> Read(int id);
    }
}
