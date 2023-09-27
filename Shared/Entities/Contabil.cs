using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class Contabil
{
    public string? CnCta { get; set; }

    public string? CnNom { get; set; }

    public bool CnMov { get; set; }

    public string? CnObj { get; set; }

    public string? CnMnd { get; set; }

    public int? CnTot { get; set; }

    public string? CnAux { get; set; }

    public float? CnAct { get; set; }

    public string? CnTip { get; set; }

    public string? CnCom { get; set; }

    public float? CnNivel { get; set; }

    public float? CnGnS { get; set; }

    public float? CnGaS { get; set; }

    public float? CnPS { get; set; }

    public float? CnS { get; set; }

    public float? CnActS { get; set; }

    public float? CnGnB { get; set; }

    public float? CnGaB { get; set; }

    public float? CnPB { get; set; }

    public float? CnB { get; set; }

    public float? CnActB { get; set; }
}
