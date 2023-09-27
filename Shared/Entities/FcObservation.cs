using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcObservation
{
    public short ObId { get; set; }

    public string ObNcode { get; set; } = null!;

    public string ObCode { get; set; } = null!;

    public string ObSuceso { get; set; } = null!;

    public string? ObDesc { get; set; }

    public string? ObEvent { get; set; }

    public string ObSec { get; set; } = null!;

    public string? ObOcode { get; set; }

    public string? ObRcode { get; set; }

    public string? ObRdet { get; set; }
}
