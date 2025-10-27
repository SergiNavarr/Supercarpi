using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Interfaces
{
    public interface IPagoService
    {
        Task<bool> RegistrarPago(Pago pago, PagoTarjeta pagoTarjeta = null);
        Task<List<Pago>> ObtenerPagosPorVenta(int ventaId);
        Task<Pago> ObtenerPagoPorId(int pagoId);
    }
}
