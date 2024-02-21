using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class TabCursoImpartir
{
    public int IdCursoImpartir { get; set; }

    public int? IdCurso { get; set; }

    public int? IdProfesor { get; set; }

    public virtual TabProfesor? IdProfesorNavigation { get; set; }
}
