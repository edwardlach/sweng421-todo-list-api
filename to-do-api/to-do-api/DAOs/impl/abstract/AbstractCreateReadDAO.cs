using System;
using to_do_api.DAOs;
using to_do_api.DAOs.@abstract;
using to_do_api.Models;
namespace to_do_api.DAOs.impl.@abstract
{
    public abstract class AbstractCreateReadDAO <MODEL>
        : AbstractReadDAO <MODEL>, IAbstractCreateReadDAO <MODEL> where MODEL : IdentifiableEntity
    {
        protected AbstractCreateReadDAO(ToDoContext dbContext) : base(dbContext) {}

        public MODEL Create(MODEL toCreate)
        {
            dbContext.Add<MODEL>(toCreate);
            dbContext.SaveChanges();
            return this.Read(toCreate.Id);
        }
    }
}
