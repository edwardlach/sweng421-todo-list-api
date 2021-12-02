using System;
using to_do.State.@abstract;
using to_do.DTOs.@abstract;
namespace to_do.State
{
    public interface IObservable <RESOURCE>
        where RESOURCE : AbstractIdentifiableDTO.AbstractIdentifiableResponse
    {
        void Subscribe(IObserver<RESOURCE> observer);
        void Unsubscribe(IObserver<RESOURCE> observer);
    }
}
