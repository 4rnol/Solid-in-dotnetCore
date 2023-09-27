using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtEjecpre
{
    public DateTime? EpPeri { get; set; }

    public DateTime? EpPerf { get; set; }

    public DateTime? EpPeai { get; set; }

    public DateTime? EpPeaf { get; set; }

    public int? EpSerPar { get; set; }

    public decimal? EpEjecPermn { get; set; }

    public decimal? EpEjecAcumn { get; set; }

    public decimal? EpEjecPerme { get; set; }

    public decimal? EpEjecAcume { get; set; }

    public string? EpMnda { get; set; }

    public string? EpTp { get; set; }

    public int? EpIdop { get; set; }

    public short? EpGes { get; set; }

    public int? EpTot { get; set; }
}
