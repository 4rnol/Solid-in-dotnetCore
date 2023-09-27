using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InTipocredito
{
    public int TcId { get; set; }

    public string TcCodigo { get; set; } = null!;

    public string TcDescripcion { get; set; } = null!;
}
