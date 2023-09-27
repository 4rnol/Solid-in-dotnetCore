using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtSubcta
{
    public int SuSerie { get; set; }

    public string? SuDesc { get; set; }

    public string? SuCod { get; set; }

    public string? SuNit { get; set; }

    public string? SuCi { get; set; }

    public string? SuEmi { get; set; }

    public int SuEmpid { get; set; }

    public string SuDetalle { get; set; } = null!;

    public bool SuClub { get; set; }

    public string SuSuc { get; set; } = null!;
}
