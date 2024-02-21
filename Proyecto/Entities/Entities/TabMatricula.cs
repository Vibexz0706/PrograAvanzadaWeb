using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class TabMatricula
{
    public int IdMatricula { get; set; }

    public int? IdEstudiante { get; set; }

    public int? IdCurso { get; set; }

    public virtual TabCurso? IdCursoNavigation { get; set; }
}
