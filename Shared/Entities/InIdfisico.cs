using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InIdfisico
{
    public int IfId { get; set; }

    public DateTime IfFecha { get; set; }

    public string IfDetalle { get; set; } = null!;
}
