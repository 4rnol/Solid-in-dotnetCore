using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcCobrocajpp
{
    public long? CoSol { get; set; }

    public string? CoCli { get; set; }

    public short? CoMes { get; set; }

    public short? CoAño { get; set; }

    public decimal? CoImp { get; set; }

    public bool? CoCobrar { get; set; }

    public int? CoIdop { get; set; }

    public short? CoSeq { get; set; }
}
