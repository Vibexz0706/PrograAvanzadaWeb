using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class TabIngrediente
{
    public int IdIngredientes { get; set; }

    public int? IdReceta { get; set; }

    public string? Ingrediente { get; set; }

    public virtual TabReceta? IdRecetaNavigation { get; set; }
}
