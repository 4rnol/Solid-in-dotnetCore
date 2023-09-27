using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtChequeNulo
{
    public int? ChSerie { get; set; }

    public string? ChBanco { get; set; }

    public string? ChPersona { get; set; }

    public int? ChNumero { get; set; }

    public DateTime? ChFecha { get; set; }

    public int? ChSertra { get; set; }

    public decimal? ChMn { get; set; }

    public int? ChSerdoc { get; set; }
}
