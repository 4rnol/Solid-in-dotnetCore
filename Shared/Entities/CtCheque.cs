using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtCheque
{
    public int ChSerie { get; set; }

    public string? ChBanco { get; set; }

    public string? ChPersona { get; set; }

    public int? ChNumero { get; set; }

    public DateTime? ChFecha { get; set; }

    public int? ChSertra { get; set; }

    public byte ChNroimp { get; set; }

    public int? ChSerdoc { get; set; }

    public decimal? ChMn { get; set; }

    public DateTime? ChFechae { get; set; }

    public DateTime? ChFechac { get; set; }

    public bool? ChNulo { get; set; }

    public string? ChTm { get; set; }

    public int ChEmpid { get; set; }

    public string ChCta { get; set; } = null!;

    public string ChTipdoc { get; set; } = null!;

    public string ChNumdoc { get; set; } = null!;
}
