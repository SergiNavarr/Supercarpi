using Datos.Interfaces;
using Entidades.Models;
using Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Implementacion
{
    public class VentaService : IVentaService
    {
        private readonly IRepositorioGenerico<Venta> _ventaRepo;
        private readonly IRepositorioGenerico<DetalleVenta> _detalleRepo;
        private readonly IRepositorioGenerico<Producto> _productoRepo;
        private readonly IPagoService _pagoService;

        public VentaService(
            IRepositorioGenerico<Venta> ventaRepo,
            IRepositorioGenerico<DetalleVenta> detalleRepo,
            IRepositorioGenerico<Producto> productoRepo,
            IPagoService pagoService)
        {
            _ventaRepo = ventaRepo;
            _detalleRepo = detalleRepo;
            _productoRepo = productoRepo;
            _pagoService = pagoService;
        }

        public async Task<bool> RegistrarVenta(Venta venta, List<DetalleVenta> detalles, Pago pago, PagoTarjeta pagoTarjeta = null)
        {
            if (detalles == null || !detalles.Any()) return false;

            decimal total = 0;

            foreach (var d in detalles)
            {
                var producto = await _productoRepo.Obtener(p => p.ProductoId == d.ProductoId);
                if (producto == null || producto.StockActual < d.Cantidad)
                    return false; // No hay stock suficiente

                d.PrecioUnitario = producto.PrecioUnitario;
                d.Subtotal = d.Cantidad * d.PrecioUnitario;
                total += d.Subtotal;

                // Descontar stock
                producto.StockActual -= d.Cantidad;
                await _productoRepo.Editar(producto);
            }

            // Guardar cabecera de venta
            venta.Total = total;
            var ventaCreada = await _ventaRepo.Crear(venta);

            // Guardar detalles
            foreach (var d in detalles)
            {
                d.VentaId = ventaCreada.VentaId;
                await _detalleRepo.Crear(d);
            }

            // Guardar pago
            pago.VentaId = ventaCreada.VentaId;
            pago.Monto = total;
            await _pagoService.RegistrarPago(pago, pagoTarjeta);

            return true;
        }
        public async Task<List<Venta>> ObtenerVentas()
        {
            var consulta = await _ventaRepo.Consultar();
            return consulta.ToList();
        }

        public async Task<Venta> ObtenerVentaPorId(int id)
        {
            return await _ventaRepo.Obtener(v => v.VentaId == id);
        }

        public async Task<bool> EliminarVenta(int id)
        {
            var venta = await _ventaRepo.Obtener(v => v.VentaId == id);
            if (venta == null) return false;

            await _ventaRepo.Eliminar(venta);
            return true;
        }
    }
}
