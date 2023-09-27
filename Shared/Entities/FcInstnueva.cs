using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcInstnueva
{
    public int? InNroso { get; set; }

    public string? InCtacli { get; set; }

    public string? InRuta { get; set; }

    public string? InNombre { get; set; }

    public string? InDirec { get; set; }

    public string? InCategAp { get; set; }

    public string? InNromed { get; set; }

    public string InLectura { get; set; } = null!;

    public decimal? InM3ctto { get; set; }

    public string? InCategAl { get; set; }

    public DateTime? InFechai { get; set; }

    public DateTime? InFechaf { get; set; }

    public string? InInsp { get; set; }

    public string? InSist { get; set; }
}
