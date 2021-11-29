using System;
using to_do_api.Models;
namespace to_do_api.DAOs.@abstract
{
    public interface IAbstractCreateReadUpdateDAO <MODEL> : IAbstractCreateReadDAO<MODEL> where MODEL : IdentifiableEntity
    {
        MODEL Update(int id, MODEL updates);
    }
}
