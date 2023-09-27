using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InArmazonInv
{
    public int ArSerInv { get; set; }

    public int ArCantidad { get; set; }

    public string ArForma { get; set; } = null!;

    public string ArMaterial { get; set; } = null!;

    public int ArSerial { get; set; }
}
