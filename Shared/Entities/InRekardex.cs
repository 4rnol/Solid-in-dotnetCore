using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InRekardex
{
    public long KaId { get; set; }

    public long? KaIddoc { get; set; }

    public DateTime? KaFecha { get; set; }

    public int? KaIdin { get; set; }

    public string? KaCodigo { get; set; }

    public string? KaTipdoc { get; set; }

    public string? KaNrodoc { get; set; }

    public string? KaNrofac { get; set; }

    public string? KaDocref { get; set; }

    public string? KaGlosa { get; set; }

    public float? KaSaldoif { get; set; }

    public float? KaIngref { get; set; }

    public float? KaSalif { get; set; }

    public float? KaSaldoff { get; set; }

    public float? KaSaldoiv { get; set; }

    public float? KaIngrev { get; set; }

    public float? KaSaliv { get; set; }

    public float? KaSaldovf { get; set; }

    public string? KaAlmacen { get; set; }

    public int? KaOper { get; set; }
}
