using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcMovcateg
{
    public DateTime? McPeriodo { get; set; }

    public DateTime? McFeclec { get; set; }

    public string McCateg { get; set; } = null!;

    public string McCargo { get; set; } = null!;

    public int McBloquei { get; set; }

    public int McBloquef { get; set; }

    public decimal McBase { get; set; }
}
