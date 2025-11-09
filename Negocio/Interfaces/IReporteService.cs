using Entidades.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Interfaces
{
    public interface IReporteService
    {
        Task<ReporteResumenDTO> GenerarReporteVentasAsync(DateTime desde, DateTime hasta, int? empleadoId, int? cajaId);
    }
}


