using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InSectore
{
    public int TsId { get; set; }

    public string TsCodigo { get; set; } = null!;

    public string TsNombre { get; set; } = null!;

    public bool TsRep { get; set; }

    public string TsCta { get; set; } = null!;
}
