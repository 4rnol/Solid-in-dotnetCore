using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtSubctasEc2
{
    public int SuIdc { get; set; }

    public decimal SuSaln { get; set; }

    public decimal SuSale { get; set; }

    public int SuIdop { get; set; }

    public string SuCc { get; set; } = null!;
}
