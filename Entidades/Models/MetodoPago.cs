using System;
using System.Collections.Generic;

namespace Entidades.Models;

public partial class MetodoPago
{
    public int MetodoPagoId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
