using System;
using System.Collections.Generic;
using to_do_api.DAOs.@abstract;
using to_do_api.DAOs;
using to_do_api.Models;
namespace to_do_api.DAOs.impl.@abstract
{
    public abstract class AbstractReadDAO <MODEL> : IAbstractReadDAO<MODEL> where MODEL : IdentifiableEntity 
    {
        protected ToDoContext dbContext;

        protected AbstractReadDAO(ToDoContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public MODEL Read(int id)
        {
            return dbContext.Find<MODEL>(id);
        }
    }
}
