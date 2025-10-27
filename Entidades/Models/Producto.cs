using System;
using System.Collections.Generic;

namespace Entidades.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public decimal PrecioUnitario { get; set; }

    public int? StockActual { get; set; }

    public int MarcaId { get; set; }

    public int CategoriaId { get; set; }

    public string? ImagenUrl {  get; set; }

    public bool EsActivo { get; set; } = true;

    public virtual Categoria Categoria { get; set; } = null!;

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual Marca Marca { get; set; } = null!;
}
