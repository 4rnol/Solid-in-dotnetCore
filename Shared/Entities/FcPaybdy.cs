using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcPaybdy
{
    public string Codigo { get; set; } = null!;

    public DateTime? Per { get; set; }

    public int Dosid { get; set; }

    public int Nfac { get; set; }

    public string Ditem { get; set; } = null!;

    public decimal Monto { get; set; }

    public bool Scf { get; set; }

    public short Seq { get; set; }

    public short Opid { get; set; }

    public short N { get; set; }

    public decimal Montou { get; set; }
}
