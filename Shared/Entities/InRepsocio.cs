using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InRepsocio
{
    public DateTime RpFecha { get; set; }

    public int RpNrodoc { get; set; }

    public decimal RpEntrada { get; set; }

    public decimal RpSalida { get; set; }

    public decimal RpSaldof { get; set; }

    public decimal RpDebe { get; set; }

    public decimal RpHaber { get; set; }

    public decimal RpSaldov { get; set; }
}
