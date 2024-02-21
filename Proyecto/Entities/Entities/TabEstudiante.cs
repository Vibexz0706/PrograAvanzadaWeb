using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class TabEstudiante
{
    public int IdEstudiante { get; set; }

    public string? Cedula { get; set; }

    public string? Nombre { get; set; }

    public string? ApellidoPat { get; set; }

    public string? ApellidoMat { get; set; }

    public string? Correo { get; set; }

    public DateOnly? FechaNacimiento { get; set; }
}
