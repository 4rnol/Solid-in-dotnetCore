using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InLote
{
    public int LoId { get; set; }

    public int LoIdbode { get; set; }

    public int LoIdprod { get; set; }

    public string LoCodigo { get; set; } = null!;

    public decimal LoCantidad { get; set; }

    public decimal LoPrecio { get; set; }

    public DateTime LoFecha { get; set; }

    public string LoUbicacion { get; set; } = null!;
}
