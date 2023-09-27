using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class Plan
{
    public string? NroCuenta { get; set; }

    public string? Descripcio { get; set; }

    public double? Cuenmoneda { get; set; }

    public string? Cuentaaju { get; set; }

    public double? Nivel { get; set; }

    public string? Descrip { get; set; }

    public bool Bctamov { get; set; }

    public bool Cchica { get; set; }

    public bool Subcuenta { get; set; }

    public double? Modulo { get; set; }

    public bool Binsumo { get; set; }

    public bool Btarea { get; set; }

    public bool Bcentcost { get; set; }

    public double? Actifluj { get; set; }
}
