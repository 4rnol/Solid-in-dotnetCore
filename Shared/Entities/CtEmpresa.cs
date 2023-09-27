using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtEmpresa
{
    public int EmId { get; set; }

    public string EmNomEmp { get; set; } = null!;

    public string EmNomBd { get; set; } = null!;

    public string EmRuc { get; set; } = null!;

    public string EmDirec { get; set; } = null!;

    public string EmLugar { get; set; } = null!;

    public string EmTelf { get; set; } = null!;

    public string EmEMail { get; set; } = null!;

    public string EmSimMn { get; set; } = null!;

    public string EmSimMe { get; set; } = null!;

    public DateTime EmPrinc { get; set; }

    public DateTime EmFinal { get; set; }

    public DateTime EmDesde { get; set; }

    public DateTime EmHasta { get; set; }

    public string? EmForLim { get; set; }

    public DateTime EmLimite { get; set; }

    public DateTime EmApert { get; set; }

    public DateTime EmAnter { get; set; }

    public string EmStatus { get; set; } = null!;
}
