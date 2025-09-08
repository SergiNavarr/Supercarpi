using System;
using System.Collections.Generic;

namespace Entidades.Models;

public partial class Pedido
{
    public int PedidoId { get; set; }

    public int EmpleadoId { get; set; }

    public DateOnly? Fecha { get; set; }

    public decimal? Total { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    public virtual Empleado Empleado { get; set; } = null!;
}
