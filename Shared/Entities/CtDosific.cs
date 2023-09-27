using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtDosific
{
    public int DsId { get; set; }

    public string DsAlfanum { get; set; } = null!;

    public string DsNauto { get; set; } = null!;

    public int DsNi { get; set; }

    public int DsNf { get; set; }

    public int DsNuso { get; set; }

    public string DsLlave { get; set; } = null!;

    public DateTime? DsFechai { get; set; }

    public DateTime? DsFechaf { get; set; }

    public DateTime? DsFeclimE { get; set; }

    public string DsEst { get; set; } = null!;

    public int DsEmpid { get; set; }

    public string? DsNit { get; set; }

    public string DsSuc { get; set; } = null!;

    public string DsActivi { get; set; } = null!;

    public bool DsUsado { get; set; }
}
