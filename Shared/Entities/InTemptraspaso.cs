using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InTemptraspaso
{
    public int TpId { get; set; }

    public int TpUsr { get; set; }

    public int TpCompu { get; set; }

    public string TpBodega { get; set; } = null!;

    public string TpLote { get; set; } = null!;

    public int TpSerinv { get; set; }

    public decimal TpPrecio { get; set; }

    public decimal TpCant { get; set; }
}
