using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcMovcliente
{
    public string McLeccod { get; set; } = null!;

    public string McLecnom { get; set; } = null!;

    public DateTime? McFeclec { get; set; }

    public string McCli { get; set; } = null!;

    public string McNom { get; set; } = null!;

    public string McDir { get; set; } = null!;

    public string McMed { get; set; } = null!;

    public string McCat { get; set; } = null!;

    public string McSrv { get; set; } = null!;

    public string McRut { get; set; } = null!;

    public short McIt { get; set; }

    public DateTime? McPeriodo { get; set; }

    public int McLecant { get; set; }

    public int McLecact { get; set; }

    public short McConavg { get; set; }

    public int McConsumo { get; set; }

    public string McObs { get; set; } = null!;
}
