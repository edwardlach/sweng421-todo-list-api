using System;
using to_do_api.Models;
namespace to_do_api.Services.@abstract
{
    public interface ICreateReadService <MODEL> : IReadService <MODEL> where MODEL : IdentifiableEntity
    {
        MODEL Create(MODEL toCreate);
    }
}
