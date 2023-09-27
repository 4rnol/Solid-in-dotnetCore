using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InTransac1
{
    public int TfSerEnc { get; set; }

    public int TfSerial { get; set; }

    public int TfItem { get; set; }

    public int TfSerIn { get; set; }

    public string TfUnidad { get; set; } = null!;

    public float TfCantPe { get; set; }

    public float TfCantAp { get; set; }

    public string TfDesc { get; set; } = null!;

    public float TfPreUn { get; set; }

    public decimal TfPreUnSus { get; set; }

    public decimal TfPreTotSus { get; set; }

    public decimal TfPreUTot { get; set; }

    public string TfSerCta { get; set; } = null!;

    public string TfSerCtaG { get; set; } = null!;

    public byte TfIngresa { get; set; }

    public bool TfGraCont { get; set; }

    public bool TfFactura { get; set; }

    public string TfLote { get; set; } = null!;

    public string TfRechazo { get; set; } = null!;
}
