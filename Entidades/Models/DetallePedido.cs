using System;
using System.Collections.Generic;

namespace Entidades.Models;

public partial class DetallePedido
{
    public int DetallePedidoId { get; set; }

    public int PedidoId { get; set; }

    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    public decimal? SubTotal { get; set; }

    public virtual Pedido Pedido { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}
