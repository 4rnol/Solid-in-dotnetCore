using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InDocumentG
{
    public int MoId { get; set; }

    public int MoCorre { get; set; }

    public string MoCodcli { get; set; } = null!;

    public string MoTipodoc { get; set; } = null!;

    public int MoNrove { get; set; }

    public DateTime MoFecha { get; set; }

    public string MoEstado { get; set; } = null!;

    public decimal MoTc { get; set; }

    public string MoMoneda { get; set; } = null!;

    public string MoGlosa { get; set; } = null!;
}
