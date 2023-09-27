using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcSector
{
    public short? SeIdare { get; set; }

    public short? SeIdcic { get; set; }

    public short SeId { get; set; }

    public string? SeCodsec { get; set; }

    public string? SeDesc { get; set; }
}
