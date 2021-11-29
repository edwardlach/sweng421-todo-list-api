using System;
using to_do_api.DAOs.@abstract;
using to_do_api.Models;
namespace to_do_api.DAOs.impl.@abstract
{
    public abstract class AbstractCreateReadUpdateDAO <MODEL>
        : AbstractCreateReadDAO <MODEL>, IAbstractCreateReadUpdateDAO<MODEL> where MODEL : TimestampedEntity
    {
        public AbstractCreateReadUpdateDAO(ToDoContext dbContext) : base(dbContext) {}

        protected abstract void ApplyUpdates(MODEL toUpdate, MODEL updates);

        public MODEL Update(int id, MODEL updates)
        {
            MODEL toUpdate = this.Read(id);
            this.ApplyUpdates(toUpdate, updates);
            toUpdate.UpdatedDate = updates.UpdatedDate;
            dbContext.SaveChanges();
            return toUpdate;
        }
    }
}
