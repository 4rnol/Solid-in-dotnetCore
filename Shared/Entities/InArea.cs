using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InArea
{
    public int ArId { get; set; }

    public string ArCodigo { get; set; } = null!;

    public string ArDesc { get; set; } = null!;
}
