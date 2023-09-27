using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CpImpNprov
{
    public int ImSerial { get; set; }

    public string ImProv1 { get; set; } = null!;

    public string ImProv2 { get; set; } = null!;

    public string ImProv3 { get; set; } = null!;

    public string ImProv4 { get; set; } = null!;

    public string ImProv5 { get; set; } = null!;

    public string ImProv6 { get; set; } = null!;

    public string ImProv7 { get; set; } = null!;

    public string ImObs { get; set; } = null!;

    public string ImNroSc { get; set; } = null!;

    public DateTime ImFecElab { get; set; }

    public DateTime ImFecAdj { get; set; }

    public string ImProv8 { get; set; } = null!;

    public string ImProv9 { get; set; } = null!;

    public string ImProv10 { get; set; } = null!;
}
