using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InTransPar
{
    public int TfIddoc { get; set; }

    public int TfId { get; set; }

    public int TfItem { get; set; }

    public int TfIdin { get; set; }

    public string TfUnidad { get; set; } = null!;

    public decimal TfCantpe { get; set; }

    public decimal TfCantap { get; set; }

    public string TfDesc { get; set; } = null!;

    public decimal TfPreun { get; set; }

    public decimal TfPreunSus { get; set; }

    public decimal TfPretotSus { get; set; }

    public decimal TfPreunTot { get; set; }

    public string TfIdcta { get; set; } = null!;

    public string TfIdctag { get; set; } = null!;

    public byte TfIngresa { get; set; }

    public bool TfGraCont { get; set; }

    public bool TfFactura { get; set; }

    public string TfLote { get; set; } = null!;

    public string TfRechazo { get; set; } = null!;

    public int TfIdprov { get; set; }
}
