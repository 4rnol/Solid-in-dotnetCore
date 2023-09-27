using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcFechavig
{
    public short FvId { get; set; }

    public DateTime? FvFecvig { get; set; }

    public decimal? FvFacindex { get; set; }

    public byte? FvMes { get; set; }

    public short? FvAño { get; set; }

    public bool? FvEst { get; set; }

    public decimal? FvUfvant { get; set; }

    public decimal? FvUfvact { get; set; }

    public DateTime? FvCreated { get; set; }

    public short FvUserc { get; set; }

    public DateTime? FvActivated { get; set; }

    public short FvUsera { get; set; }

    public short FvFibase { get; set; }
}
