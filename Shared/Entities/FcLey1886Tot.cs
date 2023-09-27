using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcLey1886Tot
{
    public short DvMes { get; set; }

    public short DvAño { get; set; }

    public string DvCod { get; set; } = null!;

    public string DvNom { get; set; } = null!;

    public string DvCi { get; set; } = null!;

    public string DvTci { get; set; } = null!;

    public DateTime? DvFnac { get; set; }

    public int DvConm3 { get; set; }

    public decimal DvD1886D { get; set; }

    public decimal DvD1886I { get; set; }

    public decimal DvTfac { get; set; }

    public int DvDosid { get; set; }

    public int DvNfac { get; set; }

    public string DvNord { get; set; } = null!;

    public string DvCcontrol { get; set; } = null!;

    public short DvOpid { get; set; }
}
