using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtPresu
{
    public int ApSerie { get; set; }

    public int? ApSercta { get; set; }

    public string? ApCta { get; set; }

    public string? ApNom { get; set; }

    public int? ApTot { get; set; }

    public byte? ApNiv { get; set; }

    public bool? ApMov { get; set; }

    public decimal? ApMn { get; set; }

    public decimal? ApMe { get; set; }

    public short? ApMes { get; set; }

    public decimal? ApMnm { get; set; }

    public decimal? ApMem { get; set; }

    public decimal ApEne { get; set; }

    public decimal ApFeb { get; set; }

    public decimal ApMar { get; set; }

    public decimal ApAbr { get; set; }

    public decimal ApMay { get; set; }

    public decimal ApJun { get; set; }

    public decimal ApJul { get; set; }

    public decimal ApAgo { get; set; }

    public decimal ApSep { get; set; }

    public decimal ApOct { get; set; }

    public decimal ApNov { get; set; }

    public decimal ApDic { get; set; }

    public int? ApSeriedp { get; set; }
}
