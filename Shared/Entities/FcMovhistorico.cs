using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcMovhistorico
{
    public string MhLeccod { get; set; } = null!;

    public DateTime? MhFeclec { get; set; }

    public string MhCli { get; set; } = null!;

    public string MhRut { get; set; } = null!;

    public DateTime? MhPeriodo { get; set; }

    public int MhConsumo { get; set; }

    public decimal MhTotal { get; set; }

    public bool MhStatus { get; set; }
}
