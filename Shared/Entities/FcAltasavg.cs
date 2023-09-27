using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcAltasavg
{
    public short FcMes { get; set; }

    public short FcAño { get; set; }

    public DateTime? FcPer { get; set; }

    public string FcCli { get; set; } = null!;

    public int FcCon { get; set; }

    public short FcN { get; set; }

    public int FcAvg { get; set; }
}
