using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CrCompra
{
    public string? CoNit { get; set; }

    public string? CoNombre { get; set; }

    public DateTime? CoFecha { get; set; }

    public string? CoNroauto { get; set; }

    public string? CoCcontrol { get; set; }

    public long? CoNrofac { get; set; }

    public decimal? CoMonto { get; set; }

    public decimal? CoIce { get; set; }

    public decimal? CoExen { get; set; }

    public byte? CoPag { get; set; }

    public int? CoNro { get; set; }

    public byte? CoGrab { get; set; }

    public int? CoEmpid { get; set; }

    public string? CoNropoli { get; set; }

    public decimal? CoImportenscf { get; set; }

    public decimal? CoSubtotal { get; set; }

    public decimal? CoDescu { get; set; }

    public decimal? CoTotalcf { get; set; }

    public string? CoTipoco { get; set; }

    public string? CoEspecifi { get; set; }

    public int? CoNroreg { get; set; }
}
