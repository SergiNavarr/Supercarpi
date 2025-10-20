using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interfaces;
using Negocio.Interfaces;

namespace Negocio.Implementacion
{
    public class BackupService : IBackupService
    {
        private readonly IBackupRepository _backupRepository;

        
        public BackupService(IBackupRepository backupRepository)
        {
            _backupRepository = backupRepository;
        }

        public async Task CrearBackupAsync(string rutaArchivo)
        {
            await _backupRepository.RealizarBackupAsync(rutaArchivo);
        }
    }
}



