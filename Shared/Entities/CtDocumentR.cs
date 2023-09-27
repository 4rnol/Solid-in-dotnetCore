using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtDocumentR
{
    public string? DcTipo { get; set; }

    public int? DcNro { get; set; }

    public DateTime? DcFecha { get; set; }

    public int? DcUsu { get; set; }

    public int DcSerie { get; set; }

    public string DcGlosa { get; set; } = null!;

    public string DcCc { get; set; } = null!;

    public string DcSuc { get; set; } = null!;
}
