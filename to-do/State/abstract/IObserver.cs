using System;
using to_do.DTOs.@abstract;
namespace to_do.State
{
    public interface IObserver<RESOURCE> where RESOURCE : AbstractIdentifiableDTO.AbstractIdentifiableResponse
    {
        void Update();
    }
}
