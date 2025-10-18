using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

using Datos.DBContext;
using Interfaz;
using Negocio.Interfaces;
using Negocio.Implementacion;
using Datos.Interfaces;
using Datos.Implementacion;

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
            services.AddTransient<Inicio>();
            services.AddTransient<FormVenta>();
            services.AddTransient<FormUsuarios>();
            services.AddTransient <FormProducto>();
            services.AddTransient<FormProveedores>();
            services.AddTransient<FormBackUp>();
            services.AddTransient<FormReportes>();

            //Registrar servicios de negocio
            services.AddTransient(typeof(IRepositorioGenerico<>), typeof(RepositorioGenerico<>));
            services.AddTransient<IEmpleadoService, EmpleadoService>();
            services.AddTransient<IUtilidadesService, UtilidadesService>();
            services.AddTransient<ICategoriaService, CategoriaService>();
            services.AddTransient<IProductoService, ProductoService>();



            var serviceProvider = services.BuildServiceProvider();

            // Ejecutar la app con Login desde DI
            Application.Run(serviceProvider.GetRequiredService<Login>());
        }
    }

}