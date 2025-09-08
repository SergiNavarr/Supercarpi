using System;
using System.Collections.Generic;

namespace Entidades.Models;

public partial class PagoTarjeta
{
    public int PagoTarjetaId { get; set; }

    public int PagoId { get; set; }

    public string NumeroTarjeta { get; set; } = null!;

    public string Titular { get; set; } = null!;

    public virtual Pago Pago { get; set; } = null!;
}
