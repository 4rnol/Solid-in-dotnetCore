using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class AfKardex
{
    public int? KdSerieaf { get; set; }

    public DateTime? KdFecha { get; set; }

    public byte? KdOp { get; set; }

    public decimal? KdVhbs { get; set; }

    public decimal? KdVhsus { get; set; }

    public decimal? KdDebs { get; set; }

    public decimal? KdDesus { get; set; }

    public decimal? KdTc { get; set; }
}
