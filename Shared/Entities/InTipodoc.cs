using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InTipodoc
{
    public int TdId { get; set; }

    public string TdCodigo { get; set; } = null!;

    public string TdDescripcion { get; set; } = null!;

    public int TdCorrelativo { get; set; }

    public string TdTipo { get; set; } = null!;

    public string TdNumera { get; set; } = null!;

    public bool? TdEstado { get; set; }

    public int TdEmpid { get; set; }
}
