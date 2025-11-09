using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DTOs
{
    public class ReporteResumenDTO
    {
        public int TotalVentas { get; set; }
        public decimal RecaudacionTotal { get; set; }
        public string MetodoPagoMasUsado { get; set; } = string.Empty;
        public string ProductoMasVendido { get; set; } = string.Empty;

        // Nuevos campos para mostrar gráficos opcionales
        public Dictionary<string, int>? VentasPorProducto { get; set; }
        public Dictionary<string, int>? VentasPorMetodoPago { get; set; }

        //Nuevos campos para mostrar los reportes por Caja
        public int? CajaId { get; set; }
        public decimal TotalVentasCaja { get; set; }
        public string MetodoPagoMasUsadoCaja { get; set; } = string.Empty;

    }
}
