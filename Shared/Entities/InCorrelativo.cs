using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InCorrelativo
{
    public int CoFlete { get; set; }

    public int CoPrestamo { get; set; }

    public int CoNotaa { get; set; }

    public int CoCuentaP { get; set; }

    public int CoNotac { get; set; }

    public bool CoAsentar { get; set; }

    public int CoCuentaC { get; set; }
}
