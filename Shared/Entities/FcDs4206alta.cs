using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcDs4206alta
{
    public short FcAño { get; set; }

    public byte FcMes { get; set; }

    public string FcCli { get; set; } = null!;

    public short FcDosid { get; set; }

    public int FcDosseq { get; set; }

    public string FcCateg { get; set; } = null!;

    public int FcCon { get; set; }

    public decimal FcIap { get; set; }

    public decimal FcPercent { get; set; }

    public decimal FcDescDom { get; set; }

    public decimal FcDesAs { get; set; }

    public string FcEstf { get; set; } = null!;

    public DateTime? FcFanu { get; set; }
}
