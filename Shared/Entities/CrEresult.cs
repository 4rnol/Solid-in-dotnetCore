using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CrEresult
{
    public string? ErTipo { get; set; }

    public string? ErCta { get; set; }

    public string? ErNom { get; set; }

    public decimal? ErMn { get; set; }

    public decimal? ErMe { get; set; }

    public byte? ErNiv { get; set; }

    public bool? ErMov { get; set; }

    public string? ErIder { get; set; }

    public int? ErEmpid { get; set; }
}
