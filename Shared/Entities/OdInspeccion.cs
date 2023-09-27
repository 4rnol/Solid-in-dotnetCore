using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class OdInspeccion
{
    public int InIdrec { get; set; }

    public short InLec { get; set; }

    public short InCon { get; set; }

    public byte InGrifos { get; set; }

    public byte InLlave { get; set; }

    public string InInspec { get; set; } = null!;

    public string InDiagn { get; set; } = null!;

    public string InComment { get; set; } = null!;

    public DateTime? HcDate { get; set; }
}
