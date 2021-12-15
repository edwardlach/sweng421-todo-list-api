using System;
using System.Windows.Forms;
using to_do.State;
using System.Net.Http;
using to_do.Services;
using to_do.Services.impl;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;


namespace to_do
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            CreateWebHostBuilder(args).Build().RunAsync();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                Timer timer = serviceProvider.GetService<Timer>();

                var initialize = serviceProvider.GetRequiredService<Initialize>();
                initialize.Run();
                var comp1 = serviceProvider.GetRequiredService<Component1>();
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
                .AddScoped<Component1>()
                .AddScoped<Form1>()
                .AddScoped<IChangePoller, ChangePoller>()
                .AddScoped<IAssignmentService, AsssignmentService>()
                .AddScoped<IMembershipService, MembershipService>()
                .AddScoped<ISubscriptionService, SubscriptionService>()
                .AddScoped<IToDoListService, ToDoListService>()
                .AddScoped<IToDoTaskService, ToDoTaskService>()
                .AddScoped<IUserService, UserService>();
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
               WebHost.CreateDefaultBuilder(args)
                   .UseStartup<Startup>()
                    .ConfigureServices((_, services) =>
                    {
                        services.AddHostedService<ChangePoller>();
                    });


    }
}
