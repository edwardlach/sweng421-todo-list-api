using System;
using System.Collections.Generic;
using to_do.State;
using System.Threading.Tasks;
using System.Threading;
using to_do.DTOs;
namespace to_do.Services.impl
{
    public class ChangePoller : IChangePoller
    {
        private IUserService userService;
        private Store store;

        public ChangePoller(
            Store store,
            IUserService userService)
        {
            this.store = store;
            this.userService = userService;
        }

        public void PollForChanges()
        {
            while(true)
            {
                var poll = Task<List<ChangeDTO.ChangeResponse>>.Run(() =>
                {
                    // TODO Make API request to get new changes for user instead
                    // of below dummy code.
                    ChangeDTO.ChangeResponse response = new ChangeDTO.ChangeResponse();
                    List<ChangeDTO.ChangeResponse> changes = new List<ChangeDTO.ChangeResponse>();
                    changes.Add(response);
                    return changes;
                });

                if (poll.Result.Count > 0)
                {
                    poll.Result.ForEach(change => this.store.ChangeState.AddTo(change));
                }
                Thread.Sleep(10000);
            }
        }
    }
}
