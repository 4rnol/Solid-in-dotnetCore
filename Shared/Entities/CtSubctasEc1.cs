using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtSubctasEc1
{
    public int SuIdc { get; set; }

    public int SuIds { get; set; }

    public decimal SuSaln { get; set; }

    public decimal SuSale { get; set; }

    public int SuIdop { get; set; }

    public decimal SuSaldon { get; set; }

    public decimal SuSaldoe { get; set; }

    public string SuCc { get; set; } = null!;
}
