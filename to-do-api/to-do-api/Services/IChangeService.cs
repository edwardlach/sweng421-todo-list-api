using System;
using System.Collections.Generic;
using to_do_api.Services.@abstract;
using to_do_api.Models;
namespace to_do_api.Services
{
    public interface IChangeService : ICreateReadService<Change>
    {
        List<Change> GetChangesForListSince(int listId, DateTime since);
    }
}
