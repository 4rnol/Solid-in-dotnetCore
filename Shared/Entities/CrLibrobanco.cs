using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CrLibrobanco
{
    public long LbId { get; set; }

    public DateTime? LbFecha { get; set; }

    public string? LbCta { get; set; }

    public string? LbGlosa { get; set; }

    public decimal? LbMn { get; set; }

    public decimal? LbMe { get; set; }

    public decimal? LbSaldo { get; set; }

    public string? LbTipo { get; set; }

    public string? LbDoc { get; set; }

    public long? LbIdtra { get; set; }

    public int? LbEmpid { get; set; }
}
