using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using Datos.Interfaces;
using System;
using System.IO;
using System.Threading.Tasks;




namespace Datos.Implementacion
{
    public class BackupRepository : IBackupRepository
    {
        private readonly string _connectionString;

        public BackupRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

     

        public async Task RealizarBackupAsync(string rutaArchivo)
        {
            string databaseName;

            // Obtener el nombre de la base de datos desde la cadena de conexión
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                databaseName = connection.Database;
            }

            // Crear carpeta si no existe
            string? folder = Path.GetDirectoryName(rutaArchivo);
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            string comando = $@"
                BACKUP DATABASE [{databaseName}]
                TO DISK = @RutaArchivo
                WITH FORMAT, INIT, SKIP, NAME = 'Backup_{databaseName}_{DateTime.Now:yyyyMMddHHmmss}'";

            using (var connection = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(comando, connection))
            {
                cmd.Parameters.AddWithValue("@RutaArchivo", rutaArchivo);
                await connection.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}
