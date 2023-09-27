using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InTransaG
{
    public int MdId { get; set; }

    public int MdIddoc { get; set; }

    public string MdDetalle { get; set; } = null!;

    public decimal MdMe { get; set; }

    public decimal MdMn { get; set; }

    public bool MdEstado { get; set; }

    public string MdDoc { get; set; } = null!;

    public string MdCta { get; set; } = null!;
}
