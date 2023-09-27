using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtComprasba
{
    public int CoId { get; set; }

    public int CoIdco { get; set; }

    public int CoSertra { get; set; }

    public string? CoProvee { get; set; }

    public string? CoNit { get; set; }

    public DateTime? CoFecha { get; set; }

    public string? CoCcontrol { get; set; }

    public string? CoNrofac { get; set; }

    public string? CoNroauto { get; set; }

    public decimal? CoMonto { get; set; }

    public decimal? CoIce { get; set; }

    public decimal? CoExento { get; set; }

    public string? CoObser { get; set; }

    public int? CoNcomp { get; set; }

    public string? CoTip { get; set; }

    public string? CoOrigen { get; set; }

    public bool CoNgrab { get; set; }

    public byte CoPag { get; set; }

    public int CoEmpid { get; set; }

    public byte CoMod { get; set; }

    public byte CoTiptra { get; set; }

    public string CoNrocta { get; set; } = null!;

    public string CoNitef { get; set; } = null!;

    public decimal CoMontopa { get; set; }

    public decimal CoMontoacu { get; set; }

    public string CoNrodocpa { get; set; } = null!;

    public byte CoTdocpago { get; set; }

    public DateTime CoFecdocpa { get; set; }

    public string CoCla { get; set; } = null!;
}
