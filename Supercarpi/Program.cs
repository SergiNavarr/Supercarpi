using Datos.DBContext;
using Datos.Implementacion;
using Datos.Interfaces;
using Interfaz;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Negocio.Implementacion;
using Negocio.Interfaces;
using System.Configuration;
using System.IO;
using System;


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

            //Registrar servicios de backup
            services.AddTransient<IBackupRepository>(sp => new BackupRepository(connectionString));
            services.AddTransient<IBackupService, BackupService>();


            var serviceProvider = services.BuildServiceProvider();

            // Ejecutar la app con Login desde DI
            Application.Run(serviceProvider.GetRequiredService<Login>());
        }
    }

}