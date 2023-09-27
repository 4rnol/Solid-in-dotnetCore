using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CliH
{
    public string? NroCta { get; set; }

    public string? Nombre { get; set; }

    public string? Paterno { get; set; }

    public string? Materno { get; set; }

    public string? Ci { get; set; }

    public double? Irun { get; set; }

    public string? Direccion { get; set; }

    public bool Activo { get; set; }

    public bool Alcant { get; set; }

    public string? Actividad { get; set; }

    public double? May06 { get; set; }

    public double? Jun06 { get; set; }

    public double? Jul06 { get; set; }

    public double? Ago06 { get; set; }

    public string? CodFac { get; set; }

    public string? CodDir { get; set; }

    public string? CodKar { get; set; }

    public double? CodMa { get; set; }

    public string? CodLote { get; set; }

    public double? MesDeu { get; set; }

    public DateTime? FecPag { get; set; }

    public DateTime? FecCorA { get; set; }

    public DateTime? FecIns { get; set; }

    public DateTime? FecCorB { get; set; }

    public string? NumFab { get; set; }

    public string? MarMed { get; set; }

    public double? DigEnt { get; set; }

    public string? Procede { get; set; }
}
