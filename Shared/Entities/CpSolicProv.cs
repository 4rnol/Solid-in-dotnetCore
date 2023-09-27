using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CpSolicProv
{
    public int CoIdnc { get; set; }

    public int CoIdprov { get; set; }

    public string CoTiempo { get; set; } = null!;

    public string CoPago { get; set; } = null!;

    public string CoEntrega { get; set; } = null!;

    public int CoIdoc { get; set; }

    public string CoOferta { get; set; } = null!;
}
