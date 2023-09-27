using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class OiOtrosi
{
    public int OiIdventa { get; set; }

    public string? OiCodcli { get; set; }

    public string OiCodserv { get; set; } = null!;

    public int? OiMes { get; set; }

    public int? OiAño { get; set; }

    public decimal OiImporte { get; set; }

    public string OiEstado { get; set; } = null!;

    public int OiCuota { get; set; }
}
