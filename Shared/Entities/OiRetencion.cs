using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class OiRetencion
{
    public int RtId { get; set; }

    public decimal RtMonto { get; set; }

    public string RtDescripcion { get; set; } = null!;
}
