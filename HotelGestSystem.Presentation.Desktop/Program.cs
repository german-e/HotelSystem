using HotelGestSystem.Data.Repositories;
using HotelGestSystem.Domain.Receptionist.Contracts;
using HotelGestSystem.Presentation.Desktop.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace HotelGestSystem.Presentation.Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Contenedor de dependecias

            var services = new ServiceCollection();
            ConfigurationServices(services);

            var provider = services.BuildServiceProvider();

            var mainform = provider.GetRequiredService<MainWindow>();
            var login = provider.GetRequiredService<LoginForm>();

            Application.Run(login);
        }


        public static void ConfigurationServices(ServiceCollection services)
        {
            services.AddScoped<IHabitacionRepository, HabitacionRepositorio>();
            services.AddTransient<MainWindow>();
            services.AddTransient<NuevaReservacionForm>();
            services.AddTransient<LoginForm>();
        }
    }
}