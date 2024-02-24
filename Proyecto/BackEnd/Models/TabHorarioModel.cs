using System;
using System.Collections.Generic;

namespace Backend.Models;

public partial class TabHorarioModel
{
    public int IdHorario { get; set; }

    public string? Horario { get; set; }

    //public virtual ICollection<TabCurso> TabCursos { get; set; } = new List<TabCurso>();
}
