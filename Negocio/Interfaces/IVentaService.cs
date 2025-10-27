using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Interfaces
{
    public interface IVentaService
    {
        Task<bool> RegistrarVenta(Venta venta, List<DetalleVenta> detalles, Pago pago, PagoTarjeta pagoTarjeta = null);
        Task<List<Venta>> ObtenerVentas();
        Task<Venta> ObtenerVentaPorId(int id);
        Task<bool> EliminarVenta(int id);
    }
}
