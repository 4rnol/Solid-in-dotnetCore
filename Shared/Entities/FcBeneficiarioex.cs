using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcBeneficiarioex
{
    public string DvCli { get; set; } = null!;

    public string DvObs { get; set; } = null!;

    public string? DvNdoc { get; set; }

    public string DvName { get; set; } = null!;
}
