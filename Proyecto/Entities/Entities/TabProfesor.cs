using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class TabProfesor
{
    public int IdProfesor { get; set; }

    public string? Cedula { get; set; }

    public string? Nombre { get; set; }

    public string? ApellidoPat { get; set; }

    public string? ApellidoMat { get; set; }

    public string? Correo { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public virtual ICollection<TabCursoImpartir> TabCursoImpartirs { get; set; } = new List<TabCursoImpartir>();
}
