using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcDs4206etrank
{
    public short EcAño { get; set; }

    public byte EcMes { get; set; }

    public string EcEt { get; set; } = null!;

    public decimal EcRan1 { get; set; }

    public decimal EcRan2 { get; set; }

    public decimal EcPercent { get; set; }

    public string EcType { get; set; } = null!;

    public byte EcSeq { get; set; }
}
