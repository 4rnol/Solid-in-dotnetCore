using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtCompra
{
    public int CoSerie { get; set; }

    public int CoSersub { get; set; }

    public int CoSertra { get; set; }

    public string? CoProvee { get; set; }

    public string CoRuc { get; set; } = null!;

    public DateTime? CoFecha { get; set; }

    public string? CoLitfac { get; set; }

    public string? CoNrofac { get; set; }

    public string? CoNumOrd { get; set; }

    public decimal? CoMonto { get; set; }

    public decimal? CoIce { get; set; }

    public decimal? CoExento { get; set; }

    public string? CoObser { get; set; }

    public int? CoNcomp { get; set; }

    public string? CoTip { get; set; }

    public string? CoOrigen { get; set; }

    public bool CoNgrab { get; set; }

    public int CoPag { get; set; }

    public DateTime CoFechaco { get; set; }

    public int CoEmpid { get; set; }

    public string CoSuc { get; set; } = null!;

    public string CoNropoli { get; set; } = null!;

    public decimal CoImportensc { get; set; }

    public decimal CoSubtotal { get; set; }

    public decimal CoDescu { get; set; }

    public decimal CoTotalcf { get; set; }

    public string CoTipoco { get; set; } = null!;
}
