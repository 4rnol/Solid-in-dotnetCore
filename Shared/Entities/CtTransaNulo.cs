using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtTransaNulo
{
    public int? TrId { get; set; }

    public short? TrCorr { get; set; }

    public int? TrSercta { get; set; }

    public int TrObj { get; set; }

    public DateTime? TrFec { get; set; }

    public int TrSerie { get; set; }

    public string? TrGlosa { get; set; }

    public decimal? TrMn { get; set; }

    public decimal? TrMe { get; set; }

    public int TrDpto { get; set; }
}
