using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcPrnoservice
{
    public short OsMes { get; set; }

    public short OsAño { get; set; }

    public string OsCod { get; set; } = null!;

    public string OsNom { get; set; } = null!;

    public string OsCateg { get; set; } = null!;

    public string OsConcept { get; set; } = null!;

    public decimal OsAmount { get; set; }

    public int OsDosid { get; set; }

    public int OsNfac { get; set; }

    public string OsNord { get; set; } = null!;

    public string OsCcontrol { get; set; } = null!;

    public string OsStep { get; set; } = null!;

    public short OsOpid { get; set; }
}
