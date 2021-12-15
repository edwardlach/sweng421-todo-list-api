using System;
using System.Collections.Generic;
using to_do.State;
using to_do.State.@abstract;
using System.Threading.Tasks;
using System.Threading;
using to_do.DTOs;

namespace to_do.Services.impl
{
    public class ChangePoller : IChangePoller
    {
        private ISubscriptionService subscriptionService;
        private Store store;
        private Timer _timer;

        public ChangePoller(
            Store store,
            ISubscriptionService subscriptionService)
        {
            this.store = store;
            this.subscriptionService = subscriptionService;
        }

        public void PollForChanges(object state)
        {
            Console.WriteLine("Polling for changes");
            CancellationToken token = (CancellationToken)state;
            List<SubscriptionDTO.SubscriptionResponse> currrentSubscriptions
                    = this.store.SubscriptionState.SelectAll();

            List<ChangeDTO.ChangeResponse> changes = new List<ChangeDTO.ChangeResponse>();
            currrentSubscriptions.ForEach(s =>
            {
                changes.AddRange(this.subscriptionService
                    .ReadSubscribedChanges(s.Id)
                    .Result.Collection);
            });
            if (changes.Count > 0)
            {
                changes.ForEach(change => this.store.ChangeState.AddTo(change));
            }

            if (token.IsCancellationRequested)
            {
                this._timer.Dispose();
            }
        }

        public async Task Start(CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                this._timer = new Timer(PollForChanges, cancellationToken, TimeSpan.Zero, TimeSpan.FromSeconds(5));
            });
        }
    }
}
