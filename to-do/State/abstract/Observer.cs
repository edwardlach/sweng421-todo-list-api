using System;
using to_do.DTOs.@abstract;
namespace to_do.State.@abstract
{
    public class Observer <RESOURCE> : IObserver<RESOURCE>
        where RESOURCE : AbstractIdentifiableDTO.AbstractIdentifiableResponse
    {
        private Func<RESOURCE, RESOURCE> update;
        private Func<int, RESOURCE> intSelector;
        private Func<RESOURCE> voidSelector;
        private int arg;
        
        public Observer(Func<RESOURCE, RESOURCE> update)
        {
            this.update = update;
        }

        public void Subscribe(
            AbstractState<RESOURCE> state,
            Func<int, RESOURCE> selector,
            int arg)
        {
            this.intSelector = selector;
            this.arg = arg;
            state.Subscribe(this);
        }

        public void Subscribe(
            AbstractState<RESOURCE> state,
            Func<RESOURCE> selector)
        {
            this.voidSelector = selector;
            state.Subscribe(this);
        }

        public void Update()
        {
            if (arg != 0)
            {
                this.update(intSelector(arg));
            }
            else
            {
                this.update(voidSelector());
            }
        }
    }
}
