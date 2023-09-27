using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CrBalance
{
    public string? BaTipo { get; set; }

    public string? BaCta { get; set; }

    public string? BaNom { get; set; }

    public decimal? BaMn { get; set; }

    public decimal? BaMe { get; set; }

    public byte? BaNiv { get; set; }

    public bool? BaMov { get; set; }

    public string? BaIdba { get; set; }

    public int? BaEmpid { get; set; }
}
