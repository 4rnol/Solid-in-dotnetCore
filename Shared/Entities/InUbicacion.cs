using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InUbicacion
{
    public int UbSerial { get; set; }

    public string UbCiudad { get; set; } = null!;

    public string UbDpto { get; set; } = null!;
}
