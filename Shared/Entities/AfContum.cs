using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class AfContum
{
    public string? CoCod { get; set; }

    public string? CoDesc { get; set; }

    public string? CoTot { get; set; }

    public decimal? CoPorcdepr { get; set; }

    public int? CoUltcorr { get; set; }

    public bool? CoMovi { get; set; }

    public byte? CoNivel { get; set; }
}
