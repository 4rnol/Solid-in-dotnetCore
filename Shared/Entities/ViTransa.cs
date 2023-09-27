using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class ViTransa
{
    public int? TrId { get; set; }

    public short? TrCorr { get; set; }

    public string? CnCta { get; set; }

    public string? Obj { get; set; }

    public string? Aux { get; set; }

    public string? TrDref { get; set; }

    public string TrGlosa { get; set; } = null!;

    public string? CnNom { get; set; }

    public decimal? TrMn { get; set; }

    public decimal? TrMe { get; set; }

    public int? CnTot { get; set; }

    public string? CnMnd { get; set; }

    public string? TrCcosto { get; set; }

    public int TrSerie { get; set; }
}
