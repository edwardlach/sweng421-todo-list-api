using System;
using System.Collections.Generic;
using to_do_api.Services.impl.@abstract;
using to_do_api.Models;
using to_do_api.DAOs;
namespace to_do_api.Services.impl
{
    public class ChangeService : AbstractCreateReadService<Change>, IChangeService
    {
        new protected IChangeDAO dao;

        public ChangeService(IChangeDAO dao) : base(dao)
        {
            this.dao = dao;
        }

        public List<Change> GetChangesForListSince(int listId, DateTime since)
        {
            return this.dao.GetChangesByListIdSince(listId, since);
        }
    }
}
