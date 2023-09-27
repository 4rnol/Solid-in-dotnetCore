using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcOt
{
    public int OtNro { get; set; }

    public int? OtNroso { get; set; }

    public string? OtInsp { get; set; }

    public string? OtObser { get; set; }

    public DateTime? OtFechai { get; set; }

    public DateTime? OtFechaf { get; set; }

    public string? OtEstado { get; set; }

    public string? OtTipo { get; set; }

    public string? OtRes { get; set; }

    public int? OtOper { get; set; }
}
