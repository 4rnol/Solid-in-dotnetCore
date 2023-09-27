using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class SiSession
{
    public short SsSession { get; set; }

    public string SsGarbage { get; set; } = null!;

    public DateTime? SsDatesession { get; set; }

    public string SsComputersession { get; set; } = null!;
}
