using System;
using System.Collections.Generic;
using to_do.DTOs;
namespace to_do.State
{
    public class Store
    {
        private UserState _userState;
        private ChangeState _changeState;

        public Store() {
            this._userState = new UserState(new List<UserDTO.UserResponse>());
            this._changeState = new ChangeState(new List<ChangeDTO.ChangeResponse>());
        }

        public Store(List<UserDTO.UserResponse> initialUsers) 
        {
            this._userState = new UserState(initialUsers);
        }

        public UserState UserState { get => _userState; }
        public ChangeState ChangeState { get => _changeState; }
    }
}
