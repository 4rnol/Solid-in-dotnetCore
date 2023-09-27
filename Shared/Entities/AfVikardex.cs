using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class AfVikardex
{
    public int AcSerie { get; set; }

    public string? AcCodcta { get; set; }

    public string? AcCorr { get; set; }

    public string? AcCodorg { get; set; }

    public string? AcCodfis { get; set; }

    public string? AcCodresp { get; set; }

    public DateTime? AcFechai { get; set; }

    public int? AcVutilI { get; set; }

    public string? AcEstado { get; set; }

    public decimal AcB { get; set; }

    public decimal? DeAcuAct { get; set; }

    public decimal? ValorNeto { get; set; }

    public decimal? AcValorI { get; set; }

    public float? AcTcI { get; set; }

    public string? AcDesc { get; set; }

    public string? AcCta { get; set; }

    public int? KdSerieaf { get; set; }

    public string? ReNombre { get; set; }

    public string? FiDesc { get; set; }

    public string? OgDesc { get; set; }
}
