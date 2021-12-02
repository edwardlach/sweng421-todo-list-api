using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using to_do.State;
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
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var comp1 = serviceProvider.GetRequiredService<Component1>();
                //var form1 = serviceProvider.GetRequiredService<Form1>();
                //Application.Run(form1);
                //Application.Run(new Form1());
            }

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services
                .AddSingleton<Store>()
                .AddScoped<Component1>()
                .AddScoped<Form1>()
                .AddScoped<IUserService, UserService>()
                .AddHttpClient<IUserService, UserService>();
        }
            
    }
}
