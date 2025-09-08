using System;
using System.Collections.Generic;

namespace Entidades.Models;

public partial class Categoria
{
    public int CategoriaId { get; set; }

    public string Nombre { get; set; } = null!;

    public int ProveedorId { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual Proveedor Proveedor { get; set; } = null!;
}
