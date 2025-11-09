using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models;
using Entidades.DTOs;

namespace Datos.Interfaces
{
    public interface IReporteRepository
    {
        Task<ReporteResumenDTO> ObtenerReporteVentasAsync(DateTime desde, DateTime hasta, int? empleadoId, int? cajaId);
    }
}
