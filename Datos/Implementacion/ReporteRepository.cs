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


        public async Task<ReporteResumenDTO> ObtenerReporteVentasAsync(DateTime desde, DateTime hasta, int? empleadoId)
        {
            var query = _context.Venta
                .Include(v => v.DetalleVenta)
                    .ThenInclude(dv => dv.Producto)
                .Include(v => v.Pagos)
                    .ThenInclude(p => p.MetodoPago)
                .AsQueryable();

            query = query.Where(v => v.Fecha >= desde && v.Fecha <= hasta);

            if (empleadoId.HasValue)
                query = query.Where(v => v.EmpleadoId == empleadoId.Value);

            var ventas = await query.ToListAsync();

            if (!ventas.Any())
                return new ReporteResumenDTO();

            // Total de ventas y recaudación
            int totalVentas = ventas.Count;
            decimal recaudacionTotal = ventas.Sum(v => v.Total);

            // Producto más vendido
            var productoMasVendido = ventas
                .SelectMany(v => v.DetalleVenta)
                .GroupBy(dv => dv.Producto.Nombre)
                .Select(g => new { Producto = g.Key, Cantidad = g.Sum(x => x.Cantidad) })
                .OrderByDescending(x => x.Cantidad)
                .FirstOrDefault()?.Producto ?? "N/A";

            // Método de pago más usado
            var metodoMasUsado = ventas
                .SelectMany(v => v.Pagos)
                .GroupBy(p => p.MetodoPago.Nombre)
                .Select(g => new { Metodo = g.Key, Cantidad = g.Count() })
                .OrderByDescending(x => x.Cantidad)
                .FirstOrDefault()?.Metodo ?? "N/A";

            // Datos para gráficos
            var ventasPorProducto = ventas
                .SelectMany(v => v.DetalleVenta)
                .GroupBy(dv => dv.Producto.Nombre)
                .ToDictionary(g => g.Key, g => g.Sum(x => x.Cantidad));

            var ventasPorMetodoPago = ventas
                .SelectMany(v => v.Pagos)
                .GroupBy(p => p.MetodoPago.Nombre)
                .ToDictionary(g => g.Key, g => g.Count());

            return new ReporteResumenDTO
            {
                TotalVentas = totalVentas,
                RecaudacionTotal = recaudacionTotal,
                ProductoMasVendido = productoMasVendido,
                MetodoPagoMasUsado = metodoMasUsado,
                VentasPorProducto = ventasPorProducto,
                VentasPorMetodoPago = ventasPorMetodoPago
            };
        }
    }


}


