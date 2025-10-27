using System;
using System.Collections.Generic;

namespace Entidades.Models;

public partial class Proveedor
{
    public int ProveedorId { get; set; }

    public string? Nombre { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public string? Cuit { get; set; }

    public string? Email { get; set; }

    public bool EsActivo { get; set; } = true;

    public virtual ICollection<Categoria> Categoria { get; set; } = new List<Categoria>();
}
