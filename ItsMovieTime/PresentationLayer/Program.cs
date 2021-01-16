using BusinessLayer;
using DataLayer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
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
                var main = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(main);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IMovieBusiness, MovieBusiness>();

            services.AddScoped<IAdministratorRepository, AdministratorRepository>();
            services.AddScoped<IAdministratorBusiness, AdministratorBusiness>();

            services.AddScoped<MainForm>();
            services.AddScoped<Admins>();
            services.AddScoped<Movies>();
            services.AddScoped<MoviePreview>();
            services.AddScoped<Login>();
            services.AddScoped<Login>();
        }
    }

}
