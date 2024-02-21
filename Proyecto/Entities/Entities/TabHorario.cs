using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class TabHorario
{
    public int IdHorario { get; set; }

    public string? Horario { get; set; }

    public virtual ICollection<TabCurso> TabCursos { get; set; } = new List<TabCurso>();
}
