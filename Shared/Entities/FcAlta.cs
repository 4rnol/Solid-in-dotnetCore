using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcAlta
{
    public string? FcArea { get; set; }

    public string? FcCic { get; set; }

    public string? FcSec { get; set; }

    public string? FcRut { get; set; }

    public int? FcIt { get; set; }

    public DateTime? FcFecl { get; set; }

    public byte? FcMes { get; set; }

    public short? FcAño { get; set; }

    public string? FcCli { get; set; }

    public string? FcTarap { get; set; }

    public string? FcTaral { get; set; }

    public string? FcObs1 { get; set; }

    public string? FcObs2 { get; set; }

    public int? FcLec { get; set; }

    public string? FcEstl { get; set; }

    public int? FcCon { get; set; }

    public short? FcSer { get; set; }

    public int? FcNum { get; set; }

    public DateTime? FcFecf { get; set; }

    public decimal? FcApcf { get; set; }

    public decimal? FcApcv { get; set; }

    public decimal? FcAlc { get; set; }

    public decimal? FcRc { get; set; }

    public string? FcEstf { get; set; }

    public string? FcEstfant { get; set; }

    public short? FcIdrefanu { get; set; }

    public DateTime? FcPag { get; set; }

    public string? FcCaj { get; set; }

    public DateTime? FcFecrefanu { get; set; }

    public byte? FcSw { get; set; }

    public int? FcSeqpre { get; set; }

    public bool? FcImpPre { get; set; }

    public string? FcCcontrol { get; set; }

    public string? FcNitci { get; set; }

    public int FcClid { get; set; }

    public int FcLecant { get; set; }

    public string FcMedidor { get; set; } = null!;

    public string? FcName { get; set; }

    public DateTime? FcFecproc { get; set; }
}
