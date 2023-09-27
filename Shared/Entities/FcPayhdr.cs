using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcPayhdr
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Direcc { get; set; } = null!;

    public string Nitci { get; set; } = null!;

    public string Rut { get; set; } = null!;

    public short Seqrut { get; set; }

    public string Cat { get; set; } = null!;

    public DateTime? Per { get; set; }

    public DateTime? Flecact { get; set; }

    public DateTime? Ffac { get; set; }

    public DateTime? Flecant { get; set; }

    public int Lecact { get; set; }

    public int Lecant { get; set; }

    public int Consumo { get; set; }

    public int Dosid { get; set; }

    public int Nfac { get; set; }

    public string Nauto { get; set; } = null!;

    public string Cctrol { get; set; } = null!;

    public DateTime? Flime { get; set; }

    public DateTime? Fpag { get; set; }

    public string Caja { get; set; } = null!;

    public DateTime? Fvenc { get; set; }

    public short Diasv { get; set; }

    public string Tpago { get; set; } = null!;

    public decimal Total { get; set; }

    public string Literal { get; set; } = null!;

    public decimal Desctos { get; set; }

    public byte[]? Qrcode { get; set; }

    public short Opid { get; set; }

    public string Doskey { get; set; } = null!;

    public short Seq { get; set; }

    public string Medidor { get; set; } = null!;

    public string Legend { get; set; } = null!;
}
