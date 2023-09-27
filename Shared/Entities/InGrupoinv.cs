using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InGrupoinv
{
    public int GrId { get; set; }

    public string GrCodigo { get; set; } = null!;

    public int GrCorr { get; set; }

    public string GrNombre { get; set; } = null!;

    public string GrObs { get; set; } = null!;

    public string GrConta { get; set; } = null!;

    public bool GrRep { get; set; }
}
