using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcPrbalancegrl
{
    public short BgSrvid { get; set; }

    public string BgConcept { get; set; } = null!;

    public decimal BgAmount { get; set; }

    public int BgOpid { get; set; }
}
