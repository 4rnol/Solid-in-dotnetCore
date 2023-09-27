using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InImpEnc
{
    public int ImSerial { get; set; }

    public string ImNroImp { get; set; } = null!;

    public string ImNro { get; set; } = null!;

    public string ImNroSolic { get; set; } = null!;

    public DateTime ImFechaOc { get; set; }

    public DateTime ImFecha { get; set; }

    public byte ImEntrega { get; set; }

    public string ImSector { get; set; } = null!;

    public string ImSolicitante { get; set; } = null!;

    public string ImNroOc { get; set; } = null!;
}
