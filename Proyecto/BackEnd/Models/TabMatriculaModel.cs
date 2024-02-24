using System;
using System.Collections.Generic;

namespace Backend.Models;

public partial class TabMatriculaModel
{
    public int IdMatricula { get; set; }

    public int? IdEstudiante { get; set; }

    public int? IdCurso { get; set; }

    //public virtual TabCurso? IdCursoNavigation { get; set; }
}
