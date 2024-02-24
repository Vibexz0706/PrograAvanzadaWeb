using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class TabInstruccion
{
    public int IdInstrucciones { get; set; }

    public int? IdReceta { get; set; }

    public string? Instruccion { get; set; }

    public virtual TabReceta? IdRecetaNavigation { get; set; }
}
