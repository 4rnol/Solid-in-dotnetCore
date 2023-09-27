using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtCajaop
{
    public int CtId { get; set; }

    public string? CtNombre { get; set; }

    public string CtCta { get; set; } = null!;

    public string CtCtaco { get; set; } = null!;

    public string CtCtaig { get; set; } = null!;

    public string? CtOp { get; set; }

    public int? CtEmpid { get; set; }
}
