using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcPret
{
    public int EtId { get; set; }

    public string EtEt { get; set; } = null!;

    public string EtUse { get; set; } = null!;

    public string EtCargo { get; set; } = null!;

    public decimal EtBase { get; set; }

    public decimal EtImporte { get; set; }

    public decimal EtFi { get; set; }

    public byte EtN { get; set; }

    public int EtIdop { get; set; }
}
