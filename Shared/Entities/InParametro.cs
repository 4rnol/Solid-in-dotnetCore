using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InParametro
{
    public int PrCorrSc { get; set; }

    public int PrCorrIr { get; set; }

    public int PrCorrCc { get; set; }

    public int PrCorrNcp { get; set; }

    public int PrCorrNs { get; set; }

    public int PrCorrNi { get; set; }

    public int PrCorrNc { get; set; }

    public int PrCorrNip { get; set; }

    public bool PrCuenta { get; set; }

    public bool PrPrecio { get; set; }

    public string PrReporte { get; set; } = null!;

    public bool PrSalida { get; set; }

    public bool PrCodlibre { get; set; }

    public bool PrCodunica { get; set; }

    public bool? PrCodgrupo { get; set; }

    public bool PrSecdoc { get; set; }
}
