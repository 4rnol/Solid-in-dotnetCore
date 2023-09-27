using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InTransac
{
    public int TfIddoc { get; set; }

    public int TfId { get; set; }

    public int TfIdin { get; set; }

    public int TfItem { get; set; }

    public string TfUnidad { get; set; } = null!;

    public decimal TfCantpe { get; set; }

    public decimal TfCantap { get; set; }

    public string TfDesc { get; set; } = null!;

    public decimal TfPrecosto { get; set; }

    public decimal TfPrecostome { get; set; }

    public decimal TfTotalco { get; set; }

    public decimal TfPreventa { get; set; }

    public decimal TfPreventame { get; set; }

    public decimal TfTotalve { get; set; }

    public byte TfIngresa { get; set; }

    public bool TfGracont { get; set; }

    public bool TfFactura { get; set; }

    public string TfLote { get; set; } = null!;

    public int TfIdprov { get; set; }

    public DateTime TfFechav { get; set; }

    public int TfSector { get; set; }

    public decimal TfCante { get; set; }

    public DateTime TfFecha { get; set; }

    public string TfSolic { get; set; } = null!;
}
