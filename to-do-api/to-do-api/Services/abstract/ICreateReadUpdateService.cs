using System;
using to_do_api.Models;
namespace to_do_api.Services.@abstract
{
    public interface ICreateReadUpdateService <MODEL> : ICreateReadService <MODEL> where MODEL : IdentifiableEntity
    {
        MODEL Update(int id, MODEL updates);
    }
}
