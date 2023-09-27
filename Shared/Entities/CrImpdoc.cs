using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CrImpdoc
{
    public int? TrSerdoc { get; set; }

    public byte? TrCorr { get; set; }

    public int? TrCta { get; set; }

    public string? TrDesc { get; set; }

    public string? TrGlosa { get; set; }

    public string? TrObj { get; set; }

    public decimal? TrMn { get; set; }

    public decimal? TrMe { get; set; }

    public int? TrId { get; set; }
}
