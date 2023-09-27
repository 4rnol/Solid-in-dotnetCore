using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcBeneficiariodv
{
    public string DvCli { get; set; } = null!;

    public DateTime? DvFnac { get; set; }

    public string DvNdoc { get; set; } = null!;

    public string DvOrigen { get; set; } = null!;

    public string DvTdoc { get; set; } = null!;

    public string DvTben { get; set; } = null!;

    public bool DvStatus { get; set; }

    public short DvGes { get; set; }

    public DateTime? DvFing { get; set; }

    public DateTime? DvFini { get; set; }

    public DateTime? DvFfin { get; set; }
}
