using System;
using to_do_api.Models;
namespace to_do_api.DAOs.@abstract
{
    public interface IAbstractCreateReadDAO <MODEL> : IAbstractReadDAO <MODEL> where MODEL : IdentifiableEntity
    {
        MODEL Create(MODEL toCreate);
    }
}
