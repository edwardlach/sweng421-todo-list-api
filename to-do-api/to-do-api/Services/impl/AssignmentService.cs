using System;
using System.Collections.Generic;
using to_do_api.Services.impl.@abstract;
using to_do_api.Models;
using to_do_api.DAOs;
namespace to_do_api.Services.impl
{
    public class AssignmentService : AbstractCreateReadUpdateService<Assignment>, IAssignmentService
    {
        new protected IAssignmentDAO dao;
        private IToDoTaskService taskService;

        public AssignmentService(
            IAssignmentDAO dao,
            IToDoTaskService taskService) : base(dao)
        {
            this.dao = dao;
            this.taskService = taskService;
        }

        public List<Assignment> ReadByUser(int userId)
        {
            return this.dao.ReadByUser(userId);
        }
    }
}
