using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcObskardex
{
    public DateTime? OkFec { get; set; }

    public string? OkCli { get; set; }

    public string? OkObs { get; set; }

    public bool? OkVerif { get; set; }

    public bool? OkCaja { get; set; }

    public int OkId { get; set; }
}
