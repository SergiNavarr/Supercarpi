using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Interfaces
{
    internal interface IVentaService
    {
        Task<int> GenerarVentaAsync(Venta venta, List<DetalleVenta> detalles);
    }
}
