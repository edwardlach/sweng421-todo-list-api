using System;
using System.Collections.Generic;
using to_do.DTOs;
namespace to_do.State
{
    public class Store
    {
        private AssignmentState _assignmentState;
        private ChangeState _changeState;
        private MembershipState _membershipState;
        private SubscriptionState _subscriptionState;
        private ToDoListState _listState;
        private ToDoTaskState _taskState;
        private UserState _userState;
        

        public Store() {
            this._assignmentState = new AssignmentState(new List<AssignmentDTO.AssignmentResponse>());
            this._changeState = new ChangeState(new List<ChangeDTO.ChangeResponse>());
            this._membershipState = new MembershipState(new List<MembershipDTO.MembershipResponse>());
            this._subscriptionState = new SubscriptionState(new List<SubscriptionDTO.SubscriptionResponse>());
            this._listState = new ToDoListState(new List<ToDoListDTO.ToDoListResponse>());
            this._taskState = new ToDoTaskState(new List<ToDoTaskDTO.ToDoTaskResponse>());
            this._userState = new UserState(new List<UserDTO.UserResponse>());
        }

        public AssignmentState AssignmentState { get => _assignmentState; }
        public ChangeState ChangeState { get => _changeState; }
        public MembershipState MembershipState { get => _membershipState; }
        public SubscriptionState SubscriptionState { get => _subscriptionState; }
        public ToDoListState ToDoListState { get => _listState; }
        public ToDoTaskState ToDoTaskState { get => _taskState; }
        public UserState UserState { get => _userState; }
    }
}
