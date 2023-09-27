using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtTipodoc
{
    public int TdId { get; set; }

    public string? TdTipo { get; set; }

    public string? TdNombre { get; set; }

    public string? TdCorr { get; set; }

    public string? TdPersona { get; set; }

    public string? TdFormato { get; set; }

    public string? TdSist { get; set; }

    public string TdFirma1 { get; set; } = null!;

    public string TdFirma2 { get; set; } = null!;

    public string TdFirma3 { get; set; } = null!;

    public string TdFirma4 { get; set; } = null!;

    public int TdOrden { get; set; }

    public int TdEmpid { get; set; }
}
