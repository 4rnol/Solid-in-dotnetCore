using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcLectura
{
    public string? Cli { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Medidor { get; set; }

    public string? Obs { get; set; }

    public int? Lectura { get; set; }

    public short? Mes { get; set; }

    public short? Anyo { get; set; }
}
