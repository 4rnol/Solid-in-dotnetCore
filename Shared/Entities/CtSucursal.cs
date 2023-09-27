using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtSucursal
{
    public int SuId { get; set; }

    public string? SuCod { get; set; }

    public string? SuNombre { get; set; }

    public int? SuEmpid { get; set; }

    public string? SuAlmacen { get; set; }

    public string? SuCtave { get; set; }

    public string? SuCtaco { get; set; }

    public string? SuSucde { get; set; }
}
