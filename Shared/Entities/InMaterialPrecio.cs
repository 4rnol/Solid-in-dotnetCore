using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InMaterialPrecio
{
    public int PcSerial { get; set; }

    public int PcSerInv { get; set; }

    public int PcSerProv { get; set; }

    public decimal PcPrecio { get; set; }
}
