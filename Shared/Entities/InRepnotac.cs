using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InRepnotac
{
    public int RnId { get; set; }

    public DateTime RnFecha { get; set; }

    public string RnNrodoc { get; set; } = null!;

    public string RnSolicitado { get; set; } = null!;

    public string RnAutorizado { get; set; } = null!;

    public decimal RnTc { get; set; }

    public bool RnAp { get; set; }

    public bool RnPcot { get; set; }

    public bool RnCot { get; set; }

    public string RnEstado { get; set; } = null!;
}
