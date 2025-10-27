using System;
using System.Collections.Generic;

namespace Entidades.Models;

public partial class Caja
{
    public int CajaId { get; set; }

    public int Numero { get; set; }

    public bool Abierto { get; set; }

    public bool EsActivo { get; set; } = true;

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
