using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class TabEstado
{
    public int IdEstado { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<TabCurso> TabCursos { get; set; } = new List<TabCurso>();

    public virtual ICollection<TabReceta> TabReceta { get; set; } = new List<TabReceta>();
}
