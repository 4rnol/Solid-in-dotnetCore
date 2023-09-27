using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class AfHisto
{
    public int? HiSerieaf { get; set; }

    public string? HiCoditem { get; set; }

    public DateTime? HiFecha { get; set; }

    public string? HiTipomov { get; set; }

    public string? HiComprob { get; set; }

    public string? HiOrgaA { get; set; }

    public string? HiOrgaN { get; set; }

    public string? HiFisiA { get; set; }

    public string? HiFisiN { get; set; }

    public string? HiRespoA { get; set; }

    public string? HiRespoN { get; set; }
}
