using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtCcosto
{
    public int CcId { get; set; }

    public string? CcCod { get; set; }

    public string? CcNom { get; set; }

    public string? CcTot { get; set; }

    public bool CcMov { get; set; }

    public byte CcNivel { get; set; }

    public int CcEmpid { get; set; }
}
