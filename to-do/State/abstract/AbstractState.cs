using System;
using System.Collections.Generic;
using to_do.State.@abstract;
using to_do.DTOs.@abstract;
namespace to_do.State
{
    public abstract class AbstractState <RESOURCE>
        : IObservable<RESOURCE> where RESOURCE : AbstractIdentifiableDTO.AbstractIdentifiableResponse
    {
        protected List<IObserver<RESOURCE>> observers = new List<IObserver<RESOURCE>>();
        protected List<RESOURCE> resources;
        protected RESOURCE active;

        protected AbstractState(List<RESOURCE> initialState)
        {
            this.resources = initialState;
        }

        public void Subscribe(IObserver<RESOURCE> observer)
        {
            this.observers.Add(observer);
        }

        public void Unsubscribe(IObserver<RESOURCE> observer)
        {
            this.observers.Remove(observer);
        }

        // Modifiers
        public void Set(List<RESOURCE> resources)
        {
            this.resources = resources;
            this.notify();
        }

        public void AddTo(RESOURCE resource)
        {
            this.resources.Add(resource);
            this.notify();
        }

        public void Update(RESOURCE resource)
        {
            this.resources.RemoveAll(r => r.Id == resource.Id);
            this.AddTo(resource);
            
        }

        public void SetActive(RESOURCE resource)
        {
            this.active = resource;
            this.notify();
        }

        // Selectors
        public RESOURCE SelectById(int id)
        {
            return this.resources.Find(r => r.Id == id);
        }

        public RESOURCE SelectActive()
        {
            return this.active;
        }

        public List<RESOURCE> SelectAll()
        {
            return this.resources;
        }

        private void notify()
        {
            this.observers.ForEach(o => o.Update());
        }
    }
}
