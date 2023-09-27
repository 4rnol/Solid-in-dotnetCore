using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CpGrupoprov
{
    public int GrId { get; set; }

    public string GrCodigo { get; set; } = null!;

    public string GrCorr { get; set; } = null!;

    public string GrDesc { get; set; } = null!;

    public string GrObs { get; set; } = null!;

    public string GrUnidad { get; set; } = null!;

    public bool GrRep { get; set; }
}
