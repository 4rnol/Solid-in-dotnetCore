using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CpTransSolic
{
    public int TrIdnc { get; set; }

    public int TrIdprov { get; set; }

    public int TrId { get; set; }

    public int TrItem { get; set; }

    public string TrCodigo { get; set; } = null!;

    public string TrUnidad { get; set; } = null!;

    public decimal TrCantidad { get; set; }

    public string TrDesc { get; set; } = null!;

    public decimal TrPrecioc { get; set; }

    public byte TrMarcado { get; set; }
}
