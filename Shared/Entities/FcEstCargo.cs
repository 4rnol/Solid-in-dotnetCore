using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcEstCargo
{
    public int? EcIdet { get; set; }

    public string? EcCargo { get; set; }

    public int? EcBloq1 { get; set; }

    public int? EcBloq2 { get; set; }

    public decimal? EcBase { get; set; }

    public short? EcIdfv { get; set; }
}
