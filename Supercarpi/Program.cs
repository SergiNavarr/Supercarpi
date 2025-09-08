using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

using Datos.DBContext;

namespace Supercarpi
{
    
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configuración
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var config = builder.Build();
            string connectionString = config.GetConnectionString("MiConexion");

            // Configuración de servicios (DI)
            var services = new ServiceCollection();

            // Registrar DbContext
            services.AddDbContext<SupercarpiDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Registrar formularios
            services.AddTransient<Login>();

            var serviceProvider = services.BuildServiceProvider();

            // Ejecutar la app con Form1 desde DI
            Application.Run(serviceProvider.GetRequiredService<Login>());
        }
    }

}