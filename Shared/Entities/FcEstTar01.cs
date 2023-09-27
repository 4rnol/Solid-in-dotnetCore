using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcEstTar01
{
    public short? EtIdfv { get; set; }

    public short? EtId { get; set; }

    public string? EtCodet { get; set; }

    public string? EtDesc { get; set; }

    public string? EtUso { get; set; }

    public string? EtTipoet { get; set; }

    public decimal? EtRc { get; set; }

    public decimal? EtReconex { get; set; }
}
