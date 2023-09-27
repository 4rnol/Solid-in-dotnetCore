using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CrEstadoejepre
{
    public int EjSercta { get; set; }

    public string EjCta { get; set; } = null!;

    public string EjNom { get; set; } = null!;

    public int? EjNivel { get; set; }

    public bool? EjMov { get; set; }

    public int? EjTot { get; set; }

    public string EjCap { get; set; } = null!;

    public string EjTip { get; set; } = null!;

    public decimal EjPreges { get; set; }

    public decimal EjPremes { get; set; }

    public decimal? EjEjecmes { get; set; }

    public decimal EjPresacu { get; set; }

    public decimal EjEjecacu { get; set; }

    public decimal EjPresaldo { get; set; }

    public int EjEmpid { get; set; }
}
