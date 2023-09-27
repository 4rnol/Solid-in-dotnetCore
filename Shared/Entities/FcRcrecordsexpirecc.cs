using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcRcrecordsexpirecc
{
    public string CcRut { get; set; } = null!;

    public short CcMes { get; set; }

    public short CcAño { get; set; }

    public string CcCli { get; set; } = null!;

    public string CcCatap { get; set; } = null!;

    public string CcCatal { get; set; } = null!;

    public decimal CcAp { get; set; }

    public decimal CcAl { get; set; }

    public decimal CcRc { get; set; }

    public decimal CcDv { get; set; }

    public decimal CcProcoop { get; set; }

    public decimal CcOi { get; set; }

    public string CcNom { get; set; } = null!;

    public string CcDirec { get; set; } = null!;

    public string CcDescr { get; set; } = null!;

    public short? CcStep { get; set; }

    public short? CcSeq { get; set; }

    public int? CcN { get; set; }

    public DateTime? CcPer { get; set; }

    public int? CcOpid { get; set; }

    public decimal? CcTotal { get; set; }
}
