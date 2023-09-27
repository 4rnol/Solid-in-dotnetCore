using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtDocpre
{
    public int PrSerie { get; set; }

    public DateTime? PrFecha { get; set; }

    public decimal? PrTc { get; set; }

    public string? PrDoc { get; set; }

    public int? PrGes { get; set; }

    public string? PrGlosa { get; set; }

    public string? PrTipo { get; set; }

    public string? PrResp { get; set; }

    public byte? PrNiv { get; set; }

    public string? PrMnd { get; set; }

    public string PrSuc { get; set; } = null!;

    public int? PrEmpid { get; set; }
}
