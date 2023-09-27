using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class OiRetenciondet
{
    public int RdId { get; set; }

    public int RdIdret { get; set; }

    public string RdDesc { get; set; } = null!;

    public decimal RdMonto { get; set; }

    public string RdCta { get; set; } = null!;
}
