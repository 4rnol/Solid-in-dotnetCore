using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InDocument
{
    public int DiId { get; set; }

    public string DiAlmacen { get; set; } = null!;

    public DateTime DiFecha { get; set; }

    public string DiTipodoc { get; set; } = null!;

    public int DiNrodoc { get; set; }

    public string DiNrosolic { get; set; } = null!;

    public string DiDocumen { get; set; } = null!;

    public decimal DiCambio { get; set; }

    public string DiNrofac { get; set; } = null!;

    public string DiNomsolic { get; set; } = null!;

    public string DiGlosa { get; set; } = null!;

    public string DiEstado { get; set; } = null!;

    public int DiNrove { get; set; }

    public DateTime DiFechaman { get; set; }

    public bool DiFac { get; set; }

    public int DiIdprocli { get; set; }

    public decimal DiToprov { get; set; }

    public int DiIdtran { get; set; }

    public decimal DiTotran { get; set; }

    public int DiIdagen { get; set; }

    public decimal DiToagen { get; set; }

    public string DiIngreso { get; set; } = null!;

    public string DiSector { get; set; } = null!;

    public string DiOp { get; set; } = null!;

    public DateTime DiFechae { get; set; }

    public string DiFormapago { get; set; } = null!;

    public string DiTipogasto { get; set; } = null!;

    public string DiCcosto { get; set; } = null!;

    public string DiVende { get; set; } = null!;

    public string DiSuc { get; set; } = null!;

    public int DiIdconta { get; set; }

    public string DiTxfac { get; set; } = null!;

    public string DiCtapag { get; set; } = null!;

    public string DiNroche { get; set; } = null!;

    public string DiNomche { get; set; } = null!;

    public string DiUser { get; set; } = null!;
}
