using System;
using System.Collections.Generic;

namespace Entidades.Models;

public partial class Empleado
{
    public int EmpleadoId { get; set; }

    public int RolId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public string PasswordHash { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual Rol Rol { get; set; } = null!;

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
