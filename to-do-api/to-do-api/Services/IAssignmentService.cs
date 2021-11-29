using System;
using System.Collections.Generic;
using to_do_api.Services.@abstract;
using to_do_api.Models;
namespace to_do_api.Services
{
    public interface IAssignmentService : ICreateReadUpdateService<Assignment>
    {
        List<Assignment> ReadByUser(int id);
    }
}
