using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtCajachica
{
    public int CaId { get; set; }

    public DateTime? CaFecha { get; set; }

    public string CaCuenta { get; set; } = null!;

    public string CaDesc { get; set; } = null!;

    public string CaPersona { get; set; } = null!;

    public string? CaProvee { get; set; }

    public string CaDocr { get; set; } = null!;

    public decimal CaMn { get; set; }

    public decimal CaIva { get; set; }

    public decimal CaGasto { get; set; }

    public string CaApconta { get; set; } = null!;

    public string CaApcontaco { get; set; } = null!;

    public string CaApcontaig { get; set; } = null!;

    public int CaIdka { get; set; }

    public int CaEmpid { get; set; }

    public string CaCcosto { get; set; } = null!;

    public decimal CaExento { get; set; }

    public decimal CaIce { get; set; }

    public string CaImp { get; set; } = null!;

    public string CaNrofac { get; set; } = null!;

    public string CaSuc { get; set; } = null!;

    public string CaNrore { get; set; } = null!;

    public string CaTipo { get; set; } = null!;

    public string CaPago { get; set; } = null!;

    public int CaIdco { get; set; }

    public int CaIddoc { get; set; }

    public string CaUser { get; set; } = null!;

    public string CaNcomp { get; set; } = null!;

    public decimal CaDescu { get; set; }
}
