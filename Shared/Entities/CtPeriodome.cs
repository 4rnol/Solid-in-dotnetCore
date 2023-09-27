using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtPeriodome
{
    public int PeId { get; set; }

    public int PeAnno { get; set; }

    public byte PeMes { get; set; }

    public bool PeEst { get; set; }

    public int PeEmpid { get; set; }
}
