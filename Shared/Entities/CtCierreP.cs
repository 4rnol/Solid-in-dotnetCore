using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtCierreP
{
    public DateTime? CiFechai { get; set; }

    public DateTime? CiFechaf { get; set; }

    public string? CiCta { get; set; }

    public string? CiNom { get; set; }

    public short? CiNiv { get; set; }

    public string? CiTot { get; set; }

    public string? CiTip { get; set; }

    public bool? CiMov { get; set; }

    public decimal? CiMn { get; set; }

    public decimal? CiMe { get; set; }

    public short? CiPer { get; set; }
}
