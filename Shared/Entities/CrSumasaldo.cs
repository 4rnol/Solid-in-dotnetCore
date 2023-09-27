using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CrSumasaldo
{
    public string? SuCta { get; set; }

    public string? SuNom { get; set; }

    public decimal? SuMnD { get; set; }

    public decimal? SuMnH { get; set; }

    public decimal? SuMnSa { get; set; }

    public decimal? SuMeD { get; set; }

    public decimal? SuMeH { get; set; }

    public decimal? SuMeSa { get; set; }

    public byte? SuNivel { get; set; }

    public bool? SuMov { get; set; }

    public int? SuEmpid { get; set; }
}
