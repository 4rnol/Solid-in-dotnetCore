using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcCambioEst
{
    public string? CeCod { get; set; }

    public short? CeMes { get; set; }

    public short? CeAño { get; set; }

    public string? CeEstAn { get; set; }

    public string? CeEstAc { get; set; }

    public int? CeLecAn { get; set; }

    public int? CeLecAc { get; set; }

    public string? CeObs { get; set; }

    public DateTime? CeDate { get; set; }

    public int? CeIdop { get; set; }

    public DateTime? CeFeclAn { get; set; }

    public DateTime? CeFeclAc { get; set; }
}
