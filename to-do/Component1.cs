using System;
using System.Collections.Generic;
using to_do.State;
using to_do.State.@abstract;
using to_do.DTOs;
using to_do.Services;
namespace to_do
{
    public class Component1
    {
        UserDTO.UserResponse user;
        Store store;
        IUserService userService;

        public Component1(Store store, IUserService userService)
        {
            this.store = store;
            this.userService = userService;

            new Observer<UserDTO.UserResponse, UserDTO.UserResponse>(
                (user) =>
                {
                    this.user = user;
                    Console.WriteLine(user.FirstName + " " + user.LastName);
                    return user;
                })
                .Subscribe(this.store.UserState, this.store.UserState.SelectActive);


            this.store.SubscriptionState.Set(
                this.userService.GetUserSubscriptions(1).Result.Collection);


            new Observer<ChangeDTO.ChangeResponse, List<ChangeDTO.ChangeResponse>>(
                (changes) =>
                {
                    changes.ForEach(c => Console.WriteLine(
                        c.Id + ": Task Id " + c.Task + " was " + c.Value));
                    return changes;
                })
                .Subscribe(this.store.ChangeState, this.store.ChangeState.SelectAll);
        }
    }
}
