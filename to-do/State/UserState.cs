using System;
using System.Collections.Generic;
using to_do.DTOs;
using to_do.State.@abstract;
namespace to_do.State
{
    public class UserState : AbstractState<UserDTO.UserResponse>
    {
        public UserState(List<UserDTO.UserResponse> initialState) : base(initialState) {}
    }
}
