using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class OiDetalle
{
    public int DeIdco { get; set; }

    public byte? DeItem { get; set; }

    public int? DeSerieop { get; set; }

    public string? DeDesc { get; set; }

    public int? DeSerieaux { get; set; }

    public int? DeCanti { get; set; }

    public decimal? DePrecioU { get; set; }

    public decimal? DeImporteT { get; set; }

    public string? DeCta { get; set; }

    public string? DeLug { get; set; }
}
