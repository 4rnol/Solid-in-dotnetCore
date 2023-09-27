using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InMovInv
{
    public string MoCta { get; set; } = null!;

    public string MoCodigo { get; set; } = null!;

    public DateTime MoFecha { get; set; }

    public DateTime MoHora { get; set; }

    public string MoDoc { get; set; } = null!;

    public float? MoSaldoV { get; set; }

    public float? MoSaldoF { get; set; }

    public float? MoEntradas { get; set; }

    public float? MoSalidas { get; set; }

    public float? MoSaldoiV { get; set; }

    public float? MoDebe { get; set; }

    public float? MoHaber { get; set; }

    public float? MoSaldoiF { get; set; }

    public string MoNroCbte { get; set; } = null!;

    public int MoSerInv { get; set; }

    public int MoOrden { get; set; }

    public string MoBodlote { get; set; } = null!;

    public int? MoOpid { get; set; }
}
