using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtUpsaldo
{
    public DateTime? AcFecha { get; set; }

    public string? AcSuc { get; set; }

    public bool? AcAm { get; set; }

    public bool? AcPm { get; set; }
}
