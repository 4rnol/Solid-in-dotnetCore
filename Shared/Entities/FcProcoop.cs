using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcProcoop
{
    public string PcCli { get; set; } = null!;

    public string? PcPer { get; set; }

    public short PcDosid { get; set; }

    public int PcDosseq { get; set; }

    public decimal PcValue { get; set; }

    public string PcStatus { get; set; } = null!;

    public DateTime? PcPag { get; set; }

    public DateTime? PcFecrefanu { get; set; }

    public DateTime? PcFproc { get; set; }
}
