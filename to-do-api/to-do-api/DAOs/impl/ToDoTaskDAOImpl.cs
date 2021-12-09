using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using to_do_api.Models;
using to_do_api.DAOs.impl.@abstract;
namespace to_do_api.DAOs.impl
{
    public class ToDoTaskDAOImpl : AbstractCreateReadUpdateDAO<ToDoTask>, IToDoTaskDAO
    {
        public ToDoTaskDAOImpl(ToDoContext dbContext) : base(dbContext) {}

        public List<ToDoTask> GetTasksByListId(int listId)
        {
            return this.dbContext.ToDoTasks
                .Where<ToDoTask>(t => t.ListId == listId)
                .ToList();
        }
        new public ToDoTask Read(int id)
        {
            return this.dbContext.ToDoTasks
                .Include<ToDoTask>("List")
                .Where<ToDoTask>(t => t.Id == id)
                .First<ToDoTask>();
        }

        new public ToDoTask Update(int id, ToDoTask updates)
        {
            base.Update(id, updates);
            return this.Read(id);
        }


        protected override void ApplyUpdates(ToDoTask toUpdate, ToDoTask updates)
        {
            if (updates.Title != null)
            {
                toUpdate.Title = updates.Title;
            }
            if (updates.Description != null)
            {
                toUpdate.Description = updates.Description;
            }
            if (updates.Priority != null)
            {
                toUpdate.Priority = updates.Priority;
            }
            if (updates.Status != null)
            {
                toUpdate.Status = updates.Status;
            }
            if (updates.DueDate != DateTime.MinValue)
            {
                toUpdate.DueDate = updates.DueDate;
            }
        }
    }
}
