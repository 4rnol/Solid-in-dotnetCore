using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcLectore
{
    public short LcId { get; set; }

    public string? LcCodlec { get; set; }

    public string? LcNom { get; set; }

    public bool? LcEst { get; set; }
}
