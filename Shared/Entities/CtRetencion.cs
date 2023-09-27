using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtRetencion
{
    public int? ReSertra { get; set; }

    public string ReTip { get; set; } = null!;

    public DateTime ReFecha { get; set; }

    public string ReProvee { get; set; } = null!;

    public string ReDesc { get; set; } = null!;

    public string ReRec { get; set; } = null!;

    public decimal ReImpT { get; set; }

    public decimal ReImpiue { get; set; }

    public decimal ReImpit { get; set; }

    public decimal ReImpR { get; set; }

    public int ReNum { get; set; }

    public string ReTipd { get; set; } = null!;

    public int ReEmpid { get; set; }

    public string ReSuc { get; set; } = null!;
}
