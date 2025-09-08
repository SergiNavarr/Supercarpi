using System;
using System.Collections.Generic;

namespace Entidades.Models;

public partial class Pago
{
    public int PagoId { get; set; }

    public int VentaId { get; set; }

    public int MetodoPagoId { get; set; }

    public DateOnly Fecha { get; set; }

    public decimal Monto { get; set; }

    public virtual MetodoPago MetodoPago { get; set; } = null!;

    public virtual PagoTarjeta? PagoTarjetum { get; set; }

    public virtual Venta Venta { get; set; } = null!;
}
