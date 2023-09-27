using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtSaldo
{
    public int? SaSercta { get; set; }

    public int SaSerie { get; set; }

    public int? SaSeraux { get; set; }

    public decimal SaGn { get; set; }

    public decimal SaGa { get; set; }

    public decimal SaP { get; set; }

    public decimal Sa { get; set; }

    public decimal SaAct { get; set; }
}
