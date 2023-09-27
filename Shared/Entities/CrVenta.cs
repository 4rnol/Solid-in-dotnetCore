using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CrVenta
{
    public DateTime? VeFecha { get; set; }

    public string? VeNroauto { get; set; }

    public string? VeNit { get; set; }

    public string? VeNombre { get; set; }

    public string? VeCcontrol { get; set; }

    public int? VeNrofac { get; set; }

    public decimal? VeTotal { get; set; }

    public decimal? VeIce { get; set; }

    public decimal? VeExen { get; set; }

    public string? VeEst { get; set; }

    public int? VePag { get; set; }

    public int? VeNro { get; set; }

    public int? VeEmpid { get; set; }

    public string? VeSuc { get; set; }

    public decimal? VeVegrata0 { get; set; }

    public decimal? VeSubtotal { get; set; }

    public decimal? VeDescu { get; set; }

    public decimal? VeTotaldf { get; set; }
}
