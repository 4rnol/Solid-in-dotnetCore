using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class AfBaja
{
    public int? BaSerieaf { get; set; }

    public string? BaCodaf { get; set; }

    public DateTime? BaFecha { get; set; }

    public string? BaComprob { get; set; }

    public int? BaUser { get; set; }
}
