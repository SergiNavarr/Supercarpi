using System;
using System.Collections.Generic;

namespace Entidades.Models;

public partial class Venta
{
    public int VentaId { get; set; }

    public DateTime Fecha { get; set; }

    public int EmpleadoId { get; set; }

    public decimal Total { get; set; }

    public int CajaId { get; set; }

    public virtual Caja Caja { get; set; } = null!;

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual Empleado Empleado { get; set; } = null!;

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
