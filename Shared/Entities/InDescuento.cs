using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InDescuento
{
    public int TdSerial { get; set; }

    public string TdCodigo { get; set; } = null!;

    public string TdTipo { get; set; } = null!;

    public string TdDesc { get; set; } = null!;

    public string TdFactor { get; set; } = null!;
}
