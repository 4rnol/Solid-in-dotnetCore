using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtTransaR
{
    public int? TrIddoc { get; set; }

    public int TrCorr { get; set; }

    public string TrSercta { get; set; } = null!;

    public int TrSerial { get; set; }

    public decimal? TrMn { get; set; }

    public decimal? TrMe { get; set; }

    public int TrSeraux { get; set; }

    public int? TrObj { get; set; }

    public string TrGlosa { get; set; } = null!;

    public string TrRefe { get; set; } = null!;

    public string TrCcosto { get; set; } = null!;
}
