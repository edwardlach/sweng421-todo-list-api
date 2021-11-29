using System;
using System.Collections.Generic;
using to_do_api.Models;
namespace to_do_api.DAOs.@abstract
{
    public interface IAbstractReadDAO <MODEL> where MODEL : IdentifiableEntity
    {
        MODEL Read(int id);
    }
}
