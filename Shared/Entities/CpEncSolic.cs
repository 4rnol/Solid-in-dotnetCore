using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CpEncSolic
{
    public int EnId { get; set; }

    public string EnTipodoc { get; set; } = null!;

    public int EnNroSc { get; set; }

    public DateTime EnFechaSc { get; set; }

    public DateTime EnFechaAp { get; set; }

    public DateTime EnFechaCot { get; set; }

    public DateTime EnFechaElab { get; set; }

    public DateTime EnFechaAdj { get; set; }

    public int EnNroOc { get; set; }

    public string EnEstado { get; set; } = null!;
}
