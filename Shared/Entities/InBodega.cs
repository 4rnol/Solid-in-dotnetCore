using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InBodega
{
    public int BoId { get; set; }

    public string BoCodigo { get; set; } = null!;

    public string BoNombre { get; set; } = null!;

    public string BoRespon { get; set; } = null!;

    public string BoDireccion { get; set; } = null!;

    public string BoCodconta { get; set; } = null!;

    public string BoContracta { get; set; } = null!;

    public string BoArea { get; set; } = null!;

    public bool BoCentral { get; set; }

    public string BoSuc { get; set; } = null!;
}
