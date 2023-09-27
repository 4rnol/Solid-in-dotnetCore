using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcCambmedi
{
    public int CmNroso { get; set; }

    public string CmCtacli { get; set; } = null!;

    public string? CmRuta { get; set; }

    public string? CmNombre { get; set; }

    public string? CmDirec { get; set; }

    public string? CmCateg { get; set; }

    public string? CmMarcaant { get; set; }

    public string? CmNromedant { get; set; }

    public string? CmMarcaact { get; set; }

    public string? CmNromedact { get; set; }

    public string? CmLectant { get; set; }

    public string? CmLectact { get; set; }

    public DateTime? CmFechai { get; set; }

    public DateTime? CmFechaf { get; set; }

    public string? CmInsp { get; set; }

    public string? CmSist { get; set; }
}
