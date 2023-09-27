using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InReservaMat
{
    public int RmNrodoc { get; set; }

    public string RmTipodoc { get; set; } = null!;

    public string RmCodigo { get; set; } = null!;

    public decimal RmCantidad { get; set; }
}
