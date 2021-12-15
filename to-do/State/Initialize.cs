using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_do.Services;
using to_do.DTOs;

namespace to_do.State
{
    internal class Initialize
    {
        IUserService userService;
        ISubscriptionService subscriptionService;
        Store store;
        IToDoListService listService;
        public Initialize(Store store, IToDoListService listService, IUserService userService, ISubscriptionService subscriptionService)
        {
            this.userService = userService;
            this.subscriptionService = subscriptionService; 
            this.store = store;       
            this.listService = listService;
        }

        public void Run()
        {
            ToDoListDTO.ToDoListResponse response = this.listService.Read(9).Result;
            UserDTO.UserResponse userResponse = this.userService.Read(2).Result;
            SubscriptionDTO.SubscriptionCollectionResponse subscriptionResponse = 
                this.userService.GetUserSubscriptions(2).Result;
            this.store.ToDoListState.SetActive(response);
            this.store.UserState.SetActive(userResponse);
            this.store.SubscriptionState.Set(subscriptionResponse.Collection);

            response.Tasks.Collection.ForEach(t =>
            {
                this.store.ToDoTaskState.AddTo(t);
            });

        }

    }
}
