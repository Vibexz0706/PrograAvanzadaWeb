using System;
using System.Collections.Generic;

namespace Backend.Models;

public partial class TabIngredienteModel
{
    public int IdIngredientes { get; set; }

    public int? IdReceta { get; set; }

    public string? Ingrediente { get; set; }

    public virtual TabRecetaModel? IdRecetaNavigation { get; set; }
}
