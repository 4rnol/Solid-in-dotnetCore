using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CtUsrDoc
{
    public int UdUsr { get; set; }

    public int UdDoc { get; set; }

    public bool UdCrea { get; set; }

    public bool UdElim { get; set; }

    public bool UdModif { get; set; }

    public bool UdConsulta { get; set; }

    public bool UdSupervisar { get; set; }

    public bool UdCorrelativo { get; set; }

    public bool UdFecha { get; set; }

    public bool UdTc { get; set; }
}
