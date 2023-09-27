using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtBanco
{
    public int BcId { get; set; }

    public string? BcSigla { get; set; }

    public string? BcNombre { get; set; }

    public int BcEmpid { get; set; }
}
