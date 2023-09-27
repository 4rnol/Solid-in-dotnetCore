using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtTransa
{
    public int? TrId { get; set; }

    public short? TrCorr { get; set; }

    public int? TrSercta { get; set; }

    public int TrObj { get; set; }

    public DateTime? TrFec { get; set; }

    public int TrSerie { get; set; }

    public string TrGlosa { get; set; } = null!;

    public decimal? TrMn { get; set; }

    public decimal? TrMe { get; set; }

    public float TrUfv { get; set; }

    public string? TrCcosto { get; set; }

    public string? TrDref { get; set; }

    public string? TrEfe { get; set; }

    public int TrScta { get; set; }

    public string TrUser { get; set; } = null!;

    public string TrCodin { get; set; } = null!;

    public long TrIdtra { get; set; }
}
