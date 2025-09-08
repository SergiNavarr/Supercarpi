﻿using System;
using System.Collections.Generic;

namespace Entidades.Models;

public partial class Marca
{
    public int MarcaId { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
