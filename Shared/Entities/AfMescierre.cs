using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class AfMescierre
{
    public DateTime? MeFecha { get; set; }

    public float? MeTc { get; set; }

    public string? MeEstado { get; set; }

    public int? MeUser { get; set; }
}
