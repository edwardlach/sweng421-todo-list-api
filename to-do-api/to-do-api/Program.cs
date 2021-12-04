using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using to_do_api.Services.impl;
using to_do_api.Services;
using to_do_api.DAOs;
using to_do_api.DAOs.impl;
using to_do_api.Controllers;
namespace to_do_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .ConfigureServices((_, services) =>
                {
                    services
                        .AddScoped<IAssignmentDAO, AssignmentDAOImpl>()
                        .AddScoped<IChangeDAO, ChangeDAOImpl>()
                        .AddScoped<IMembershipDAO, MembershipDAOImpl>()
                        .AddScoped<ISubscriptionDAO, SubscriptionDAOImpl>()
                        .AddScoped<IToDoListDAO, ToDoListDAOImpl>()
                        .AddScoped<IToDoTaskDAO, ToDoTaskDAOImpl>()
                        .AddScoped<IUserDAO, UserDAOImpl>()
                        .AddScoped<IAssignmentService, AssignmentService>()
                        .AddScoped<IChangeService, ChangeService>()
                        .AddScoped<IMembershipService, MembershipService>()
                        .AddScoped<ISubscriptionService, SubscriptionService>()
                        .AddScoped<IToDoListService, ToDoListService>()
                        .AddScoped<IToDoTaskService, ToDoTaskService>()
                        .AddScoped<IUserService, UserService>()
                        .AddTransient<AssignmentsController>()
                        .AddTransient<MembershipsController>()
                        .AddTransient<SubscriptionsController>()
                        .AddTransient<ToDoListsController>()
                        .AddTransient<ToDoTasksController>()
                        .AddTransient<UsersController>();
                });
    }
}
