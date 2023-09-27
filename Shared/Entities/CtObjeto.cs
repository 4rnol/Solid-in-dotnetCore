using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtObjeto
{
    public string? ObCod { get; set; }

    public string? ObDesc { get; set; }

    public bool ObMov { get; set; }

    public int? ObTot { get; set; }

    public int ObSerie { get; set; }

    public byte? ObNivel { get; set; }

    public string? ObTa { get; set; }

    public decimal ObMn { get; set; }

    public decimal ObMe { get; set; }

    public short? ObGes { get; set; }

    public int ObEmpid { get; set; }
}
