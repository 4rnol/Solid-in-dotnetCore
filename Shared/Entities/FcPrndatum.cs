using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcPrndatum
{
    public int PdId { get; set; }

    public string PdCli { get; set; } = null!;

    public DateTime? PdPer { get; set; }

    public string PdConcept { get; set; } = null!;

    public decimal PdAmount { get; set; }

    public string PdEstf { get; set; } = null!;

    public short PdSeq { get; set; }

    public int PdOpid { get; set; }

    public short PdDosid { get; set; }

    public int PdDosseq { get; set; }

    public string PdNauto { get; set; } = null!;

    public string PdCcontrol { get; set; } = null!;

    public string PdMedidor { get; set; } = null!;

    public string PdCateg { get; set; } = null!;
}
