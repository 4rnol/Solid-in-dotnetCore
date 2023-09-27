using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InSaldosf
{
    public string SaIdalm { get; set; } = null!;

    public int SaIdin { get; set; }

    public int SaId { get; set; }

    public decimal SaFact { get; set; }

    public decimal SaVact { get; set; }
}
