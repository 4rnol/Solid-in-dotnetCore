using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtContabil
{
    public int CnSerie { get; set; }

    public string? CnCta { get; set; }

    public string? CnNom { get; set; }

    public bool CnMov { get; set; }

    public string? CnObj { get; set; }

    public string? CnMnd { get; set; }

    public int? CnTot { get; set; }

    public string? CnAux { get; set; }

    public int? CnAct { get; set; }

    public string? CnTip { get; set; }

    public string? CnCom { get; set; }

    public byte CnNivel { get; set; }

    public bool CnEfe { get; set; }

    public bool CnCcosto { get; set; }

    public decimal CnGnS { get; set; }

    public decimal CnGaS { get; set; }

    public decimal CnPS { get; set; }

    public decimal CnS { get; set; }

    public decimal CnActS { get; set; }

    public decimal CnGnB { get; set; }

    public decimal CnGaB { get; set; }

    public decimal CnPB { get; set; }

    public decimal CnB { get; set; }

    public decimal CnActB { get; set; }

    public int CnEmpid { get; set; }
}
