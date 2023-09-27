using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class SiUsuario
{
    public int UsId { get; set; }

    public string UsNombre { get; set; }

    public string UsDepto { get; set; }

    public string UsLogin { get; set; }

    public string UsPassword { get; set; }

    public string? SiToken { get; set; }
}
