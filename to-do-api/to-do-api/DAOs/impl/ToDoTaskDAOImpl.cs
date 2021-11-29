using System;
using to_do_api.Models;
using to_do_api.DAOs.impl.@abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace to_do_api.DAOs.impl
{
    public class ToDoTaskDAOImpl : AbstractCreateReadUpdateDAO<ToDoTask>, IToDoTaskDAO
    {
        public ToDoTaskDAOImpl(ToDoContext dbContext) : base(dbContext) {}

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
