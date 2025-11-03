using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interfaces;
using Entidades.DTOs;
using Negocio.Interfaces;

namespace Negocio.Implementacion
{
    public class ReporteService : IReporteService
    {
        private readonly IReporteRepository _reporteRepository;

        public ReporteService(IReporteRepository reporteRepository)
        {
            _reporteRepository = reporteRepository;
        }

        public async Task<ReporteResumenDTO> GenerarReporteVentasAsync(DateTime desde, DateTime hasta, int? empleadoId)
        {
            return await _reporteRepository.ObtenerReporteVentasAsync(desde, hasta, empleadoId);
        }
    }
}
