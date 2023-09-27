using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcPlapagfac
{
    public long? PpId { get; set; }

    public string? PpCli { get; set; }

    public short? PpMes { get; set; }

    public short? PpAño { get; set; }

    public decimal? PpMonto { get; set; }
}
