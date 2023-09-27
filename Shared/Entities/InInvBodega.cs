using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InInvBodega
{
    public int BiId { get; set; }

    public int BiIdinv { get; set; }

    public string BiCodigoba { get; set; } = null!;

    public string BiCodigo { get; set; } = null!;

    public string BiCodbode { get; set; } = null!;

    public string BiNombode { get; set; } = null!;

    public decimal BiSaldo { get; set; }

    public decimal BiCant { get; set; }

    public decimal BiPrecosto { get; set; }

    public DateTime BiFechave { get; set; }
}
