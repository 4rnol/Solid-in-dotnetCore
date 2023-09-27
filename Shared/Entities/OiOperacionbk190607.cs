using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class OiOperacionbk190607
{
    public int OpId { get; set; }

    public string OpCod { get; set; } = null!;

    public string? OpNombre { get; set; }

    public string? OpTipo { get; set; }

    public string OpCta1 { get; set; } = null!;

    public string OpCta2 { get; set; } = null!;

    public decimal? OpImporte { get; set; }

    public short? OpCantidad { get; set; }

    public string? OpEstado { get; set; }

    public string? OpDoc { get; set; }

    public string OpLugar { get; set; } = null!;

    public string? OpIva { get; set; }

    public bool? OpIsfixed { get; set; }

    public string? OpWhichone { get; set; }
}
