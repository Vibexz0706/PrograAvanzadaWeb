using System;
using System.Collections.Generic;

namespace Backend.Models;

public partial class TabInstruccionModel
{
    public int IdInstrucciones { get; set; }

    public int? IdReceta { get; set; }

    public string? Instruccion { get; set; }

    public virtual TabRecetaModel? IdRecetaNavigation { get; set; }
}
