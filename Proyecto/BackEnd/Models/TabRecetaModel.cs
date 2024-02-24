using System;
using System.Collections.Generic;

namespace Backend.Models;

public partial class TabRecetaModel
{
    public int IdReceta { get; set; }

    public string? NomReceta { get; set; }

    public string? Duracion { get; set; }

    public string? Porciones { get; set; }

    public DateOnly? FechaCreacion { get; set; }

    public int? IdEstado { get; set; }

    public virtual TabEstadoModel? IdEstadoNavigation { get; set; }

    public virtual ICollection<TabIngredienteModel> TabIngredientes { get; set; } = new List<TabIngredienteModel>();

    public virtual ICollection<TabInstruccionModel> TabInstruccion { get; set; } = new List<TabInstruccionModel>();
}
