using System;
using to_do_api.Services.@abstract;
using to_do_api.Models;
using to_do_api.DAOs.@abstract;
namespace to_do_api.Services.impl.@abstract
{
    public abstract class AbstractCreateReadService <MODEL>
        : AbstractReadService <MODEL>, ICreateReadService <MODEL> where MODEL : IdentifiableEntity
    {
        new protected IAbstractCreateReadDAO<MODEL> dao;

        protected AbstractCreateReadService(IAbstractCreateReadDAO<MODEL> dao) : base(dao)
        {
            this.dao = dao;
        }

        public MODEL Create(MODEL toCreate)
        {
            return dao.Create(toCreate);
        }        
    }
}
