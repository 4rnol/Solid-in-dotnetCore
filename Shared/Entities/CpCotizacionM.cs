using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CpCotizacionM
{
    public string SoArchivo { get; set; } = null!;

    public int SoSerial { get; set; }

    public DateTime SoFecha { get; set; }

    public string SoUbicacion { get; set; } = null!;
}
