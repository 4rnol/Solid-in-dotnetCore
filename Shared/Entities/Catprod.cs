using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class Catprod
{
    public string? Codigo { get; set; }

    public string? Descrip { get; set; }

    public string? Cuenta { get; set; }

    public double? Monto1 { get; set; }

    public double? Monto2 { get; set; }

    public double? Monto3 { get; set; }

    public double? Monto4 { get; set; }

    public bool Estado { get; set; }
}
