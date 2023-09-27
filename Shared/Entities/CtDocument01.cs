using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtDocument01
{
    public string? DcTip { get; set; }

    public int? DcNum { get; set; }

    public int? DcNsepsa { get; set; }

    public DateTime? DcFecha { get; set; }

    public int DcSerie { get; set; }

    public string DcGlosa { get; set; } = null!;

    public decimal? DcTc { get; set; }

    public int? DcCre { get; set; }

    public DateTime? DcHora { get; set; }

    public int? DcPer { get; set; }

    public bool? DcNulo { get; set; }

    public int DcEmpid { get; set; }

    public bool DcAju { get; set; }

    public string DcCodsuc { get; set; } = null!;

    public string DcUser { get; set; } = null!;
}
