using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DBContext;
using Datos.Interfaces;
using Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Entidades.DTOs;


namespace Datos.Implementacion
{
    public class ReporteRepository : IReporteRepository
    {
        private readonly SupercarpiDbContext _context;

        public ReporteRepository(SupercarpiDbContext context)
        {
            _context = context;
        }

        public async Task<ReporteResumenDTO> ObtenerReporteVentasAsync(DateTime desde, DateTime hasta, int? empleadoId, int? cajaId)
        {
            var query = _context.Venta
                .Include(v => v.DetalleVenta)
                    .ThenInclude(dv => dv.Producto)
                .Include(v => v.Pagos)
                    .ThenInclude(p => p.MetodoPago)
                .AsQueryable();

            // Filtrar por rango de fechas
            query = query.Where(v => v.Fecha >= desde && v.Fecha <= hasta);

            // Filtrar por empleado si se pasa
            if (empleadoId.HasValue)
                query = query.Where(v => v.EmpleadoId == empleadoId.Value);

            // Filtrar por caja si se pasa
            if (cajaId.HasValue)
                query = query.Where(v => v.CajaId == cajaId.Value);

            var ventas = await query.ToListAsync();

            if (!ventas.Any())
                return new ReporteResumenDTO();

            // Totales generales
            int totalVentas = ventas.Count;
            decimal recaudacionTotal = ventas.Sum(v => v.Total);

            // Producto más vendido
            var productoMasVendido = ventas
                .SelectMany(v => v.DetalleVenta)
                .GroupBy(dv => dv.Producto.Nombre)
                .Select(g => new { Producto = g.Key, Cantidad = g.Sum(x => x.Cantidad) })
                .OrderByDescending(x => x.Cantidad)
                .FirstOrDefault()?.Producto ?? "N/A";

            // Método de pago más usado (global)
            var metodoMasUsado = ventas
                .SelectMany(v => v.Pagos)
                .GroupBy(p => p.MetodoPago.Nombre)
                .Select(g => new { Metodo = g.Key, Cantidad = g.Count() })
                .OrderByDescending(x => x.Cantidad)
                .FirstOrDefault()?.Metodo ?? "N/A";

            // 🔹 Crear resumen por caja
            var resumenPorCaja = ventas
                .GroupBy(v => v.CajaId)
                .Select(g => new ReporteCajaDTO
                {
                    CajaId = g.Key ,
                    MontoTotal = g.Sum(v => v.Total),
                    MetodoPagoMasUsado = g.SelectMany(v => v.Pagos)
                                          .GroupBy(p => p.MetodoPago.Nombre)
                                          .OrderByDescending(pg => pg.Count())
                                          .Select(pg => pg.Key)
                                          .FirstOrDefault() ?? "N/A"
                })
                .ToList();

            // 🔹 Si se seleccionó una caja específica, calcular sus totales
            decimal totalPorCaja = 0m;
            string metodoMasUsadoCaja = "N/A";

            if (cajaId.HasValue)
            {
                var cajaResumen = resumenPorCaja.FirstOrDefault(r => r.CajaId == cajaId.Value);
                if (cajaResumen != null)
                {
                    totalPorCaja = cajaResumen.MontoTotal;
                    metodoMasUsadoCaja = cajaResumen.MetodoPagoMasUsado;
                }
            }

            // Datos para gráficos
            var ventasPorProducto = ventas
                .SelectMany(v => v.DetalleVenta)
                .GroupBy(dv => dv.Producto.Nombre)
                .ToDictionary(g => g.Key, g => g.Sum(x => x.Cantidad));

            var ventasPorMetodoPago = ventas
                .SelectMany(v => v.Pagos)
                .GroupBy(p => p.MetodoPago.Nombre)
                .ToDictionary(g => g.Key, g => g.Count());

            // 🔹 Retornar todo junto
            return new ReporteResumenDTO
            {
                TotalVentas = totalVentas,
                RecaudacionTotal = recaudacionTotal,
                ProductoMasVendido = productoMasVendido,
                MetodoPagoMasUsado = metodoMasUsado,
                VentasPorProducto = ventasPorProducto,
                VentasPorMetodoPago = ventasPorMetodoPago,

                // Datos específicos si hay filtro de caja
                CajaId = cajaId,
                TotalVentasCaja = totalPorCaja,
                MetodoPagoMasUsadoCaja = metodoMasUsadoCaja,

                // 🔹 Resumen completo por todas las cajas encontradas
                ResumenPorCaja = resumenPorCaja
            };
        }
    }
}


