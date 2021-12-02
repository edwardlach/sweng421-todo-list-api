using System;
using to_do.State;
using to_do.State.@abstract;
using to_do.DTOs;
namespace to_do
{
    public class Component1
    {
        UserDTO.UserResponse user;
        Store store;

        public Component1(Store store)
        {
            this.store = store;

            new Observer<UserDTO.UserResponse>(
                (user) =>
                {
                    this.user = user;
                    Console.Write(user.FirstName + " " + user.LastName);
                    return user;
                })
                .Subscribe(this.store.UserState, this.store.UserState.SelectActive);

            this.store.UserState.SetActive(this.store.UserState.SelectById(1));
        }
    }
}
