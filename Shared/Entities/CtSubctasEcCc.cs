using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtSubctasEcCc
{
    public string SuCc { get; set; } = null!;

    public string SuNom { get; set; } = null!;

    public decimal SuSaln { get; set; }

    public decimal SuSale { get; set; }

    public int SuIdop { get; set; }
}
