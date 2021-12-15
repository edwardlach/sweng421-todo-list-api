﻿using System;
using System.Collections.Generic;
using to_do.State;
using to_do.State.@abstract;
using System.Threading.Tasks;
using System.Threading;
using to_do.DTOs;
using Microsoft.Extensions.Hosting;
namespace to_do.Services.impl


{
    public class ChangePoller : IChangePoller, IHostedService
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
            CancellationToken token = (CancellationToken)state;
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

                if (token.IsCancellationRequested)
                {
                    break;
                }
            }             
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            this._timer = new Timer(PollForChanges, cancellationToken, TimeSpan.Zero, TimeSpan.FromSeconds(5));
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
