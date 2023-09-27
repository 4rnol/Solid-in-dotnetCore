using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class OiCobranza
{
    public int CoId { get; set; }

    public string? CoCliente { get; set; }

    public string? CoRuc { get; set; }

    public string? CoTipo { get; set; }

    public DateTime? CoFechaVe { get; set; }

    public string? CoUserVe { get; set; }

    public DateTime? CoFechaCo { get; set; }

    public string? CoUserCo { get; set; }

    public int? CoSerdosif { get; set; }

    public int? CoNumfac { get; set; }

    public decimal? CoTotfac { get; set; }

    public decimal? CoTotcob { get; set; }

    public string? CoEstado { get; set; }

    public string? CoCodserv { get; set; }

    public string? CoSistema { get; set; }

    public string? CoDoc { get; set; }

    public bool? CoEstadoAlm { get; set; }

    public bool? CoTipov { get; set; }

    public bool? CoCuota { get; set; }

    public string? CoPago { get; set; }

    public string? CoCta { get; set; }

    public string CoNroauto { get; set; } = null!;

    public string CoCcontrol { get; set; } = null!;

    public string CoCodigo { get; set; } = null!;

    public string CoDirec { get; set; } = null!;
}
