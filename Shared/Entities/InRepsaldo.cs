using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InRepsaldo
{
    public DateTime? SaFecha { get; set; }

    public string? SaCodcli { get; set; }

    public string? SaDesc { get; set; }

    public decimal? SaMonto { get; set; }

    public decimal? SaSaldo { get; set; }

    public string? SaDoc { get; set; }

    public decimal? SaTc { get; set; }

    public int? SaUser { get; set; }
}
