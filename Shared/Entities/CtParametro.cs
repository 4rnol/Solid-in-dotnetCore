using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtParametro
{
    public decimal? PrIva { get; set; }

    public string? PrCtaCf { get; set; }

    public string? PrCtaDf { get; set; }

    public decimal? PrIt { get; set; }

    public string? PrCtaIt { get; set; }

    public string? PrCtaItp { get; set; }

    public string PrCtaRserv { get; set; } = null!;

    public string PrCtaRrciva { get; set; } = null!;

    public string PrCtaRbienes { get; set; } = null!;

    public string PrCtaRit { get; set; } = null!;

    public decimal PrItf { get; set; }

    public string PrCtaAi { get; set; } = null!;

    public string PrCtaI { get; set; } = null!;

    public string PrCtaE { get; set; } = null!;

    public string PrCtaRg { get; set; } = null!;

    public string PrCtaCja { get; set; } = null!;

    public int PrEmpid { get; set; }

    public string PrCtaCjachi { get; set; } = null!;
}
