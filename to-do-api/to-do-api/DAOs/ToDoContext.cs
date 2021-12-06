using System;
using Microsoft.EntityFrameworkCore;
using to_do_api.Models;
namespace to_do_api.DAOs
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) {}

        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<Change> Changes { get; set; }

        public DbSet<Membership> Memberships { get; set; }

        public DbSet<Subscription> Subscriptions { get; set; }

        public DbSet<ToDoList> ToDoLists { get; set; }

        public DbSet<ToDoTask> ToDoTasks { get; set; }

        public DbSet<User> Users { get; set; }

        public string DbPath { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
