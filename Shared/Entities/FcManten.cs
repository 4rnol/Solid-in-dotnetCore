using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcManten
{
    public string? MaCtacli { get; set; }

    public string? MaOp { get; set; }

    public DateTime? MaFecha { get; set; }

    public DateTime? MaHora { get; set; }

    public string? MaObs { get; set; }

    public int? MaUsu { get; set; }
}
