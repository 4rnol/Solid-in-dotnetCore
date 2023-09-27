using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcPrbalanceFA
{
    public string? PbCli { get; set; }

    public int? PbNfac { get; set; }

    public short? PbMes { get; set; }

    public short? PbAño { get; set; }

    public decimal? PbImporte { get; set; }

    public DateTime? PbPag { get; set; }

    public string? PbCaj { get; set; }

    public DateTime? PbHanu { get; set; }

    public string? PbMot { get; set; }

    public string? PbCcontrol { get; set; }

    public int PbN { get; set; }

    public short? PbIdop { get; set; }
}
