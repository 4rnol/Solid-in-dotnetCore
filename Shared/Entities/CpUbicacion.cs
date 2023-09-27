using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CpUbicacion
{
    public int UbId { get; set; }

    public string UbCiudad { get; set; } = null!;

    public string UbDpto { get; set; } = null!;
}
