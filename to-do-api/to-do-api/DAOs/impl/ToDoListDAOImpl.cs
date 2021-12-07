using System;
using to_do_api.Models;
using to_do_api.DAOs.impl.@abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace to_do_api.DAOs.impl


{
    public class ToDoListDAOImpl : AbstractCreateReadUpdateDAO<ToDoList>, IToDoListDAO
    {
        public ToDoListDAOImpl(ToDoContext dbContext) : base(dbContext) {}

        protected override void ApplyUpdates(ToDoList toUpdate, ToDoList updates)
        {
            if (updates.Name != null)
            {
                toUpdate.Name = updates.Name;
            }
        }

        new public ToDoList Read(int id)
        {
            return this.dbContext.ToDoLists
                .Include<ToDoList>("Tasks")
                .Where<ToDoList>(l => l.Id == id)
                .First();
        }
    }
}
