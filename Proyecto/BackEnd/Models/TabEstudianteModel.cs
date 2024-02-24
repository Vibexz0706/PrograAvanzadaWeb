using System;
using System.Collections.Generic;

namespace Backend.Models;

public partial class TabEstudianteModel
{
    public int IdEstudiante { get; set; }

    public string? Cedula { get; set; }

    public string? Nombre { get; set; }

    public string? ApellidoPat { get; set; }

    public string? ApellidoMat { get; set; }

    public string? Correo { get; set; }

    public DateOnly? FechaNacimiento { get; set; }
}
