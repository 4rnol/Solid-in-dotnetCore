using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtSubctasEc
{
    public int SuIdt { get; set; }

    public string SuDoc { get; set; } = null!;

    public string SuGlosa { get; set; } = null!;

    public DateTime? SuFec { get; set; }

    public string SuTip { get; set; } = null!;

    public int SuNum { get; set; }

    public string SuRef { get; set; } = null!;

    public decimal SuTc { get; set; }

    public decimal SuDbn { get; set; }

    public decimal SuHbn { get; set; }

    public decimal SuSaldon { get; set; }

    public decimal SuDbe { get; set; }

    public decimal SuHbe { get; set; }

    public decimal SuSaldoe { get; set; }

    public short SuNivel { get; set; }

    public int SuIdop { get; set; }

    public int? SuIdp { get; set; }

    public int SuIdc { get; set; }

    public int SuIds { get; set; }

    public string SuCc { get; set; } = null!;
}
