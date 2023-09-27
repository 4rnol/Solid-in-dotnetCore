using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcStatisticTf01
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Ruta { get; set; } = null!;

    public short Mes { get; set; }

    public int Año { get; set; }

    public string Categap { get; set; } = null!;

    public string Categas { get; set; } = null!;

    public DateTime? Feclant { get; set; }

    public DateTime? Feclact { get; set; }

    public int Lecant { get; set; }

    public int Lecact { get; set; }

    public int Consumo { get; set; }

    public decimal Minimo { get; set; }

    public decimal Exedente { get; set; }

    public decimal Descdom { get; set; }

    public decimal Ialc { get; set; }

    public decimal Desas { get; set; }

    public decimal Irc { get; set; }

    public decimal Iley1886 { get; set; }

    public decimal? Itotal { get; set; }

    public short Dosid { get; set; }

    public int Dosseq { get; set; }

    public string Ccontrol { get; set; } = null!;

    public short Opid { get; set; }
}
