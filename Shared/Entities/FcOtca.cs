using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcOtca
{
    public int OtNroot { get; set; }

    public int? OtNroso { get; set; }

    public string? OtNromed { get; set; }

    public string? OtMarca { get; set; }

    public int? OtLectura { get; set; }

    public string? OtMotivo { get; set; }

    public string? OtClase { get; set; }

    public string OtAmp { get; set; } = null!;

    public string OtDig { get; set; } = null!;

    public DateTime? OtFechai { get; set; }

    public DateTime? OtFechaf { get; set; }

    public string? OtEstado { get; set; }

    public int? OtEjec { get; set; }
}
