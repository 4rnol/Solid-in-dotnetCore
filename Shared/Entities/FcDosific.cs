using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcDosific
{
    public short DsId { get; set; }

    public DateTime? DsFec { get; set; }

    public string? DsArea { get; set; }

    public string? DsNum { get; set; }

    public string? DsLit { get; set; }

    public long? DsN0 { get; set; }

    public long? DsN1 { get; set; }

    public string DsEst { get; set; } = null!;

    public long? DsNuso { get; set; }

    public string? DsType { get; set; }

    public string? DsLlave { get; set; }

    public DateTime? DsFeclimE { get; set; }

    public DateTime? DsFecClose { get; set; }

    public string? DsLegend { get; set; }
}
