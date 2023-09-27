using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CrUtilidadb
{
    public int UbId { get; set; }

    public string? UbTipo { get; set; }

    public string? UbCta { get; set; }

    public string? UbCcosto { get; set; }

    public decimal? UbMn { get; set; }

    public decimal? UbMe { get; set; }

    public decimal? UbMnc { get; set; }

    public decimal? UbMec { get; set; }

    public int? UbUser { get; set; }

    public string? UbSuc { get; set; }

    public int? UbEmpid { get; set; }
}
