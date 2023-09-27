using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CrBalancompa
{
    public string? BaTipo { get; set; }

    public string? BaCta { get; set; }

    public string? BaNom { get; set; }

    public decimal? BaMnan { get; set; }

    public decimal? BaMnac { get; set; }

    public decimal? BaMnvar { get; set; }

    public decimal? BaPorc { get; set; }

    public byte? BaNiv { get; set; }

    public bool? BaMov { get; set; }

    public string? BaIdba { get; set; }

    public int? BaEmpid { get; set; }
}
