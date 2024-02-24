using System;
using System.Collections.Generic;

namespace Backend.Models;

public partial class TabEstadoModel
{
    public int IdEstado { get; set; }

    public string? Estado { get; set; }

    //public virtual ICollection<TabCurso> TabCursos { get; set; } = new List<TabCurso>();

    public virtual ICollection<TabRecetaModel> TabReceta { get; set; } = new List<TabRecetaModel>();
}
