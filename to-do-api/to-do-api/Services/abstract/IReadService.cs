using System;
using to_do_api.Models;
namespace to_do_api.Services.@abstract
{
    public interface IReadService <MODEL> where MODEL : IdentifiableEntity
    {
        MODEL Read(int id);
    }
}
