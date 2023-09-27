using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcComhist
{
    public string? HcId { get; set; }

    public string? HcCli { get; set; }

    public DateTime? HcFi { get; set; }

    public DateTime? HcFc { get; set; }

    public string? HcEst { get; set; }
}
