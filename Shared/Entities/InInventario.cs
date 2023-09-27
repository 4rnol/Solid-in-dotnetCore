using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InInventario
{
    public int InId { get; set; }

    public string InCodant { get; set; } = null!;

    public string InCodigoba { get; set; } = null!;

    public string InCodigo { get; set; } = null!;

    public string InNombre { get; set; } = null!;

    public string InUnidad { get; set; } = null!;

    public string InDesc { get; set; } = null!;

    public decimal InPrecom { get; set; }

    public decimal InPrepon { get; set; }

    public decimal InPrecosto { get; set; }

    public decimal InPrecostous { get; set; }

    public decimal InPreventa { get; set; }

    public decimal InPreventaus { get; set; }

    public decimal InPreventamax { get; set; }

    public bool? InVenta { get; set; }

    public decimal InCantmin { get; set; }

    public decimal InCantmax { get; set; }

    public decimal InPuntoped { get; set; }

    public byte InNivel { get; set; }

    public int InGrupo { get; set; }

    public bool InStock { get; set; }

    public byte InProceso { get; set; }

    public DateTime InFechaC { get; set; }

    public DateTime InFechaM { get; set; }

    public bool InLote { get; set; }

    public bool InCompra { get; set; }

    public string InMed1 { get; set; } = null!;

    public string InMed2 { get; set; } = null!;

    public float InLongmt { get; set; }

    public float InLongpu { get; set; }

    public string InForma { get; set; } = null!;

    public byte InEmpid { get; set; }
}
