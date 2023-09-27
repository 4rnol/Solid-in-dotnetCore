using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcCambnomb
{
    public int CnNroso { get; set; }

    public string CnCtacli { get; set; } = null!;

    public string? CnPoste { get; set; }

    public string? CnNombreant { get; set; }

    public string? CnNombrenue { get; set; }

    public string? CnDireccion { get; set; }

    public string? CnCateg { get; set; }

    public string? CnNromed { get; set; }

    public DateTime? CnFechai { get; set; }

    public DateTime? CnFechaf { get; set; }

    public string? CnInsp { get; set; }

    public string? CnSist { get; set; }
}
