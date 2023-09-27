using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InGrupoProm
{
    public int GrSerial { get; set; }

    public string GrCodigo { get; set; } = null!;

    public string GrCorr { get; set; } = null!;

    public string GrNombre { get; set; } = null!;

    public string GrCiudad { get; set; } = null!;

    public bool GrRep { get; set; }
}
