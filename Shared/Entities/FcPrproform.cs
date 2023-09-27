using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcPrproform
{
    public string? PrCli { get; set; }

    public string? PrMed { get; set; }

    public string? PrPer { get; set; }

    public decimal? PrImp { get; set; }

    public string? PrIns { get; set; }

    public short? PrSeq { get; set; }

    public DateTime? PrFval { get; set; }

    public string? PrLit { get; set; }

    public short? PrIdop { get; set; }

    public int? PrLact { get; set; }

    public int? PrLant { get; set; }

    public int? PrCon { get; set; }
}
