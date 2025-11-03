using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models;

namespace Datos.Interfaces
{
    public interface IReporteRepository
    {
        Task<List<Venta>> ObtenerVentasPorPeriodoAsync(DateTime desde, DateTime hasta);
    }
}
