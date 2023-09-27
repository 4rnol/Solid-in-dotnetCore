using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcPlapaghead
{
    public long PpId { get; set; }

    public string? PpCli { get; set; }

    public DateTime? PpFsol { get; set; }

    public short? PpNcuotas { get; set; }

    public decimal? PpPagomin { get; set; }

    public decimal? PpTotdeuda { get; set; }

    public DateTime? PpFcie { get; set; }

    public string? PpEstc { get; set; }

    public string? PpEst { get; set; }

    public short? PpIdanu { get; set; }

    public string? PpType { get; set; }

    public DateTime? PpStartp { get; set; }

    public int? PpSrvid { get; set; }

    public short? PpTcuotas { get; set; }

    public decimal? PpCash { get; set; }
}
