using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcLey1886
{
    public string? LeCli { get; set; }

    public short? LeMes { get; set; }

    public short? LeAño { get; set; }

    public decimal? LeMonto { get; set; }

    public string? LeEst { get; set; }

    public int LeDosid { get; set; }

    public int LeDosseq { get; set; }

    public DateTime? LePag { get; set; }

    public DateTime? LeFecproc { get; set; }
}
