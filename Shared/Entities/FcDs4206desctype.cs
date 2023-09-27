using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcDs4206desctype
{
    public short EcAño { get; set; }

    public byte EcMes { get; set; }

    public string EcEt { get; set; } = null!;

    public string EcType { get; set; } = null!;
}
