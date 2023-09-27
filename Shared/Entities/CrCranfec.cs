using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CrCranfec
{
    public DateTime? RfFeci { get; set; }

    public DateTime? RfFecf { get; set; }

    public byte RfMnal { get; set; }

    public string? RfIdrep { get; set; }

    public bool RfMext { get; set; }
}
