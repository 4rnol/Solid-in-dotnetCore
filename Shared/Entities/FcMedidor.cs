using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcMedidor
{
    public string MeCtacli { get; set; } = null!;

    public string? MeNumero { get; set; }

    public string? MeMarca { get; set; }

    public string? MeDigitos { get; set; }

    public string? MeMedestado { get; set; }

    public int? MeLectura { get; set; }

    public string? MeAño { get; set; }

    public string? MeEstado { get; set; }

    public DateTime? MeFechai { get; set; }
}
