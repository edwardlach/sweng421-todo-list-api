using System;
using to_do.DTOs.@abstract;
namespace to_do.State.@abstract
{
    public class Observer <RESOURCE, RESPONSE> : IObserver<RESOURCE>
        where RESOURCE : AbstractIdentifiableDTO.AbstractIdentifiableResponse
    {
        private Func<RESPONSE, RESPONSE> update;
        private Func<int, RESPONSE> intSelector;
        private Func<RESPONSE> voidSelector;
        private int arg;
        
        public Observer(Func<RESPONSE, RESPONSE> update)
        {
            this.update = update;
        }

        public void Subscribe(
            AbstractState<RESOURCE> state,
            Func<int, RESPONSE> selector,
            int arg)
        {
            this.intSelector = selector;
            this.arg = arg;
            state.Subscribe(this);
        }

        public void Subscribe(
            AbstractState<RESOURCE> state,
            Func<RESPONSE> selector)
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
