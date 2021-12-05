using System;
using System.Collections.Generic;
using to_do.State;
using to_do.State.@abstract;
using System.Threading.Tasks;
using System.Threading;
using to_do.DTOs;
using Microsoft.Extensions.Hosting;

namespace to_do.Services.impl
{
    public class ChangePoller : IHostedService, IChangePoller
    {
        private IUserService userService;
        private ISubscriptionService subscriptionService;
        private Store store;

        public ChangePoller(
            Store store,
            IUserService userService,
            ISubscriptionService subscriptionService)
        {
            this.store = store;
            this.userService = userService;
            this.subscriptionService = subscriptionService;
        }

        public void PollForChanges()
        {
            Task.Run(() =>
            {
                List<SubscriptionDTO.SubscriptionResponse> currrentSubscriptions
                        = new List<SubscriptionDTO.SubscriptionResponse>();

                new Observer<
                        SubscriptionDTO.SubscriptionResponse,
                        List<SubscriptionDTO.SubscriptionResponse>>(
                    (subscriptions) =>
                    {
                        currrentSubscriptions = subscriptions;
                        return subscriptions;
                    })
                    .Subscribe(this.store.SubscriptionState, this.store.SubscriptionState.SelectAll);

                while (true)
                {

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
                    Thread.Sleep(10000);
                }
            });               
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            List<SubscriptionDTO.SubscriptionResponse> currrentSubscriptions
                        = new List<SubscriptionDTO.SubscriptionResponse>();

            new Observer<
                    SubscriptionDTO.SubscriptionResponse,
                    List<SubscriptionDTO.SubscriptionResponse>>(
                (subscriptions) =>
                {
                    currrentSubscriptions = subscriptions;
                    return subscriptions;
                })
                .Subscribe(this.store.SubscriptionState, this.store.SubscriptionState.SelectAll);

            while (true)
            {

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
                Thread.Sleep(10000);
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
