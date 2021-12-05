using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using to_do_api.Services;
using to_do_api.DTOs;

namespace to_do_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUserService userService;
        private readonly IAssignmentService assignmentService;
        private readonly ISubscriptionService subscriptionService;

        public UsersController(
            ILogger<UsersController> logger,
            IUserService userService,
            IAssignmentService assignmentService,
            ISubscriptionService subscriptionService)
        {
            _logger = logger;
            this.userService = userService;
            this.assignmentService = assignmentService;
            this.subscriptionService = subscriptionService;
        }

        // POST users
        [HttpPost]
        public UserDTO.UserResponse Create(UserDTO.UserCreateRequest newUser)
        {
            return new UserDTO.UserResponse(this.userService.Create(newUser.ToModel()));
        }

        // GET users/{id}
        [HttpGet("{id}")]
        public UserDTO.UserResponse Get(int id)
        {
            return new UserDTO.UserResponse(this.userService.Read(id));
        }

        // GET users/{id}/assignments
        [HttpGet("{id}/assignments")]
        public AssignmentDTO.AssignmentCollectionResponse GetUserAssignments(int id)
        {
            return new AssignmentDTO.AssignmentCollectionResponse(
                this.assignmentService.ReadByUser(id));
        }

        // GET users/{id}/subscriptions
        [HttpGet("{id}/subscriptions")]
        public SubscriptionDTO.SubscriptionCollectionResponse GetUserSubscriptions(int id)
        {
            return new SubscriptionDTO.SubscriptionCollectionResponse(
                this.subscriptionService.ReadForUser(id));
        }

        // PUT users/{id}
        [HttpPut("{id}")]
        public UserDTO.UserResponse Update(int id, UserDTO.UserUpdateRequest updates)
        {
            return new UserDTO.UserResponse(this.userService.Update(id, updates.ToModel()));
        }
    }
}
