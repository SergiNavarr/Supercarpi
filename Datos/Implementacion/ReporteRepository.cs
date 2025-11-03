using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DBContext;
using Datos.Interfaces;
using Entidades.Models;
using Microsoft.EntityFrameworkCore;


namespace Datos.Implementacion
{
    public class ReporteRepository : IReporteRepository
    {
        private readonly SupercarpiDbContext _context;

        public ReporteRepository(SupercarpiDbContext context)
        {
            _context = context;
        }

        public async Task<List<Venta>> ObtenerVentasPorPeriodoAsync(DateTime desde, DateTime hasta)
        {
            return await _context.Venta
                .Include(v => v.DetalleVenta)
                    .ThenInclude(dv => dv.Producto)
                //.Include(v => v.MetodoPago)
                .Include(v => v.Empleado)
                .Where(v => v.Fecha >= desde && v.Fecha <= hasta)
                .ToListAsync();
        }

    }
}
