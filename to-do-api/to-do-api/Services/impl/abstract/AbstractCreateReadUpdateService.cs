using System;
using to_do_api.Services.@abstract;
using to_do_api.Models;
using to_do_api.DAOs.@abstract;
using System.Threading.Tasks;
using System.Threading;

namespace to_do_api.Services.impl.@abstract
{
    public class AbstractCreateReadUpdateService <MODEL>
        : AbstractCreateReadService <MODEL>, ICreateReadUpdateService <MODEL> where MODEL : IdentifiableEntity
    {
        new protected IAbstractCreateReadUpdateDAO<MODEL> dao;

        public AbstractCreateReadUpdateService(IAbstractCreateReadUpdateDAO<MODEL> dao) : base(dao)
        {
            this.dao = dao;
        }

        public MODEL Update(int id, MODEL updates)
        {
            return this.dao.Update(id, updates);
        }
    }
}
