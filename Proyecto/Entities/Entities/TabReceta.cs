using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class TabReceta
{
    public int IdReceta { get; set; }

    public string? NomReceta { get; set; }

    public string? Duracion { get; set; }

    public string? Porciones { get; set; }

    public DateOnly? FechaCreacion { get; set; }

    public int? IdEstado { get; set; }

    public virtual TabEstado? IdEstadoNavigation { get; set; }

    public virtual ICollection<TabIngrediente> TabIngredientes { get; set; } = new List<TabIngrediente>();

    public virtual ICollection<TabInstruccion> TabInstruccions { get; set; } = new List<TabInstruccion>();
}
