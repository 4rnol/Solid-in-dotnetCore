using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcPrbalance
{
    public string? PbCli { get; set; }

    public int? PbNfac { get; set; }

    public short? PbMes { get; set; }

    public short? PbAño { get; set; }

    public decimal? PbAp { get; set; }

    public decimal? PbAl { get; set; }

    public decimal? PbRc { get; set; }

    public decimal? PbInt { get; set; }

    public decimal? PbRec { get; set; }

    public decimal? PbLey1886 { get; set; }

    public decimal? PbOi { get; set; }

    public decimal? PbProcoop { get; set; }

    public DateTime? PbPag { get; set; }

    public string? PbCaj { get; set; }

    public string? PbTar { get; set; }

    public string? PbCcontrol { get; set; }

    public short? PbMesO { get; set; }

    public int? PbAñoO { get; set; }

    public int PbN { get; set; }

    public short? PbDosid { get; set; }

    public short? PbIdop { get; set; }
}
