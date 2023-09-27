using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcCobrocaj
{
    public string? CoCli { get; set; }

    public short? CoMes { get; set; }

    public short? CoAño { get; set; }

    public DateTime? CoFecf { get; set; }

    public decimal? CoServ { get; set; }

    public decimal? CoInt { get; set; }

    public decimal? CoIntPc { get; set; }

    public decimal? CoRec { get; set; }

    public decimal? CoMul { get; set; }

    public decimal? CoMulPc { get; set; }

    public decimal? CoOi { get; set; }

    public bool? CoCobrar { get; set; }

    public int? CoIdop { get; set; }

    public bool? CoTope { get; set; }

    public string? CoEstf { get; set; }

    public int? CoIddos { get; set; }

    public int? CoNumdos { get; set; }
}
