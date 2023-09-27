using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcPrplanpago
{
    public long? PpIdsol { get; set; }

    public string? PpCli { get; set; }

    public DateTime? PpFsol { get; set; }

    public byte? PpNpagos { get; set; }

    public decimal? PpPagmin { get; set; }

    public decimal? PpTdeuda { get; set; }

    public byte? PpNpagados { get; set; }

    public decimal? PpTpagado { get; set; }

    public DateTime? PpFclose { get; set; }

    public string? PpType { get; set; }

    public int? PpIdop { get; set; }

    public short? PpDiasmora { get; set; }

    public short? PpMes { get; set; }

    public short? PpAño { get; set; }

    public DateTime? PpNow { get; set; }

    public DateTime? PpPagpla { get; set; }

    public DateTime? PpFpag { get; set; }

    public string? PpCaja { get; set; }

    public int? PpNrec { get; set; }
}
