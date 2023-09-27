using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcAjustfac
{
    public short? AfSerfacO { get; set; }

    public int? AfNumfacO { get; set; }

    public short? AfSerfacR { get; set; }

    public int? AfNumfacR { get; set; }

    public short? AfMes { get; set; }

    public short? AfAño { get; set; }

    public string? AfCli { get; set; }

    public string? AfTipo { get; set; }

    public DateTime? AfFecaju { get; set; }

    public short? AfDosidncd { get; set; }

    public int? AfDosseqncd { get; set; }

    public string? AfCctrlncd { get; set; }

    public decimal? AfAmounto { get; set; }

    public decimal? AfAmountn { get; set; }

    public string? AfNitci { get; set; }
}
