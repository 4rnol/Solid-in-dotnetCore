using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CpFirma
{
    public string FrFirma { get; set; } = null!;

    public int FrSerial { get; set; }

    public float FrMonto { get; set; }
}
