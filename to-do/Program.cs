using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using to_do.State;
using System.Net.Http;
using System.Threading;
using to_do.DTOs;
using to_do.Services;
using to_do.Services.impl;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace to_do
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var initialize = serviceProvider.GetRequiredService<Initialize>();
                initialize.Run();
                var changePoller = serviceProvider.GetRequiredService<ChangePoller>();
                _ = changePoller.Start(new CancellationToken());
               
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services
                .AddSingleton<Store>()
                .AddSingleton<HttpClient>()
                .AddSingleton<ChangePoller>()
                .AddSingleton<Initialize>()
                .AddScoped<Form1>()
                .AddScoped<IChangePoller, ChangePoller>()
                .AddScoped<IAssignmentService, AsssignmentService>()
                .AddScoped<IMembershipService, MembershipService>()
                .AddScoped<ISubscriptionService, SubscriptionService>()
                .AddScoped<IToDoListService, ToDoListService>()
                .AddScoped<IToDoTaskService, ToDoTaskService>()
                .AddScoped<IUserService, UserService>();
        }
     

    }
}
