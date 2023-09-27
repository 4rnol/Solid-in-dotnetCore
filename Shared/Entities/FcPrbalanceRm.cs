using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcPrbalanceRm
{
    public int PbAño { get; set; }

    public short PbMes { get; set; }

    public decimal PbMont { get; set; }

    public short PbN { get; set; }

    public int PbIdop { get; set; }

    public short PbType { get; set; }
}
