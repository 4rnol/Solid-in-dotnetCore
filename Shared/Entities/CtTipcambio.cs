using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtTipcambio
{
    public DateTime TcFecha { get; set; }

    public decimal? TcBolsin { get; set; }

    public decimal? TcCompra { get; set; }

    public decimal? TcVenta { get; set; }

    public float TcUfv { get; set; }

    public string TcAct { get; set; } = null!;
}
