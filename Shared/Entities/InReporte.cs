using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InReporte
{
    public string RpNombre { get; set; } = null!;

    public string RpDireccion { get; set; } = null!;

    public bool RpEstado { get; set; }
}
