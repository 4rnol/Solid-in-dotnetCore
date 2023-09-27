using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class AfActivofi
{
    public int AcSerie { get; set; }

    public string? AcCta { get; set; }

    public string? AcCodcta { get; set; }

    public string? AcCorr { get; set; }

    public string? AcDesc { get; set; }

    public string? AcCodorg { get; set; }

    public string? AcCodfis { get; set; }

    public string? AcCodresp { get; set; }

    public string? AcComprob { get; set; }

    public string? AcEstado { get; set; }

    public DateTime? AcFechai { get; set; }

    public decimal? AcValorI { get; set; }

    public float? AcTcI { get; set; }

    public int? AcVutilI { get; set; }

    public decimal AcGaB { get; set; }

    public decimal AcB { get; set; }

    public decimal AcGaS { get; set; }

    public decimal AcS { get; set; }

    public decimal AcGaBd { get; set; }

    public decimal AcBd { get; set; }

    public decimal AcGaSd { get; set; }

    public decimal AcSd { get; set; }

    public string? AcGrupo { get; set; }
}
