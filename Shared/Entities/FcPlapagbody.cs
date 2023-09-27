using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcPlapagbody
{
    public long? PpId { get; set; }

    public short? PpMes { get; set; }

    public short? PpAño { get; set; }

    public DateTime? PpPagpla { get; set; }

    public decimal? PpMonto { get; set; }

    public DateTime? PpFpag { get; set; }

    public string? PpCaj { get; set; }

    public DateTime? PpFanu { get; set; }

    public short? PpIdanu { get; set; }

    public string? PpEst { get; set; }

    public int? PpNrecibo { get; set; }

    public bool? PpReconex { get; set; }

    public short? PpSeq { get; set; }

    public int? PpCoid { get; set; }

    public short PpDosid { get; set; }
}
