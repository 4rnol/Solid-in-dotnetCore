using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class OiFacanu
{
    public int FcSerief { get; set; }

    public int FcNumf { get; set; }

    public string FcLiteral { get; set; } = null!;

    public string FcNroOrden { get; set; } = null!;

    public string FcObs { get; set; } = null!;

    public DateTime FcFecha { get; set; }

    public int FcUser { get; set; }

    public int FcIdco { get; set; }

    public string? FcCaj { get; set; }

    public DateTime? FcPag { get; set; }

    public string? FcCli { get; set; }
}
