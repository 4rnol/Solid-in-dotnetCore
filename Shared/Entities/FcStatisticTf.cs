using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcStatisticTf
{
    public short? TfMes { get; set; }

    public int? TfAño { get; set; }

    public string? TfTar { get; set; }

    public int? TfCon { get; set; }

    public decimal? TfCf { get; set; }

    public decimal? TfAp { get; set; }

    public decimal? TfAl { get; set; }

    public decimal? TfApal { get; set; }

    public decimal? TfLey { get; set; }

    public int? TfTotclimin { get; set; }

    public int? TfTotclinor { get; set; }

    public int? TfTotclifac { get; set; }

    public short? TfType { get; set; }

    public int? TfIdop { get; set; }

    public decimal? TfRc { get; set; }

    public decimal TfProcoop { get; set; }

    public decimal TfOie { get; set; }
}
