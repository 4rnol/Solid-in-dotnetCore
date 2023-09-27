using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcTecnico
{
    public string TeCod { get; set; } = null!;

    public string? TeNombre { get; set; }

    public string? TeUnidad { get; set; }

    public string? TeActividad { get; set; }

    public string? TeDesUni { get; set; }
}
