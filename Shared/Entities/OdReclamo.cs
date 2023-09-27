using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class OdReclamo
{
    public int ReId { get; set; }

    public string ReTipo { get; set; } = null!;

    public string ReDetalle { get; set; } = null!;

    public DateTime? ReFrecep { get; set; }

    public DateTime? ReFsol { get; set; }

    public string ReRes { get; set; } = null!;

    public DateTime? ReFres { get; set; }

    public int ReTiempo { get; set; }

    public int ReOper { get; set; }

    public string ReEstado { get; set; } = null!;

    public string ReConforme { get; set; } = null!;

    public bool ReSisab { get; set; }

    public string ReDocobs { get; set; } = null!;

    public string? ReNomsol { get; set; }

    public string? ReCisol { get; set; }

    public string? ReTelsol { get; set; }

    public string? ReVisitasol { get; set; }

    public string? ReSexo { get; set; }
}
