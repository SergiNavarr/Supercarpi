using Datos.Interfaces;
using Entidades.DTOs;
using Entidades.Models;
using Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Implementacion
{
    public class ReporteService : IReporteService
    {
        private readonly IReporteRepository _reporteRepository;

        public ReporteService(IReporteRepository reporteRepository)
        {
            _reporteRepository = reporteRepository;
        }

        public async Task<ReporteResumenDTO> GenerarReporteVentasAsync(DateTime desde, DateTime hasta, int? empleadoId, int? cajaId)
        {
            return await _reporteRepository.ObtenerReporteVentasAsync(desde, hasta, empleadoId, cajaId);
        }

        public async Task<List<Venta>> ObtenerVentasAsync(DateTime desde, DateTime hasta, int? empleadoId, int? cajaId)
        {
            return await _reporteRepository.ObtenerVentasListAsync(desde, hasta, empleadoId, cajaId);
        }
    }
}
