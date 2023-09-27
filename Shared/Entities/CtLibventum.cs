using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtLibventum
{
    public int VeSerie { get; set; }

    public string? VeOrigen { get; set; }

    public DateTime? VeFecha { get; set; }

    public string VeNroord { get; set; } = null!;

    public string VeAlfanum { get; set; } = null!;

    public int VeNrofac { get; set; }

    public string? VeNit { get; set; }

    public string? VeNombre { get; set; }

    public decimal VeTotal { get; set; }

    public decimal VeExento { get; set; }

    public decimal VeIce { get; set; }

    public decimal VeCrefis { get; set; }

    public string VeObser { get; set; } = null!;

    public string VeTip { get; set; } = null!;

    public string VeNcomp { get; set; } = null!;

    public string VeEst { get; set; } = null!;

    public int VeSertra { get; set; }

    public byte VePag { get; set; }

    public int VeEmpid { get; set; }

    public string VeSuc { get; set; } = null!;

    public decimal VeVegrata0 { get; set; }

    public decimal VeSubtotal { get; set; }

    public decimal VeDescu { get; set; }

    public decimal VeTotaldf { get; set; }
}
