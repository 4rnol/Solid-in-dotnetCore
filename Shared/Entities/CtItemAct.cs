using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtItemAct
{
    public int ItSerDoc { get; set; }

    public int? ItSerTra { get; set; }

    public int? ItSerCta { get; set; }

    public string ItCodAct { get; set; } = null!;

    public byte ItCantidad { get; set; }

    public string ItItem { get; set; } = null!;

    public string ItDesc { get; set; } = null!;

    public float ItPrecio { get; set; }

    public int ItSerie { get; set; }
}
