using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcCorRec
{
    public string? CoArea { get; set; }

    public string? CoCic { get; set; }

    public string? CoSec { get; set; }

    public string? CoRut { get; set; }

    public short? CoIt { get; set; }

    public string? CoCli { get; set; }

    public short? CoMesCorte { get; set; }

    public short? CoAñoCorte { get; set; }

    public DateTime? CoFord { get; set; }

    public short? CoMesC { get; set; }

    public short? CoAñoC { get; set; }

    public short? CoMesToppag { get; set; }

    public short? CoAñoToppag { get; set; }

    public short? CoMesMora { get; set; }

    public short? CoAñoMora { get; set; }

    public string? CoCauc { get; set; }

    public DateTime? CoFcor { get; set; }

    public string? CoResc { get; set; }

    public short? CoN { get; set; }

    public decimal? CoTdeuda { get; set; }

    public string? CoEncc { get; set; }

    public string? CoLugC { get; set; }

    public string? CoObs { get; set; }

    public string? CoEstcli { get; set; }

    public DateTime? ReFord { get; set; }

    public string? ReCaur { get; set; }

    public DateTime? ReFrec { get; set; }

    public string? ReResr { get; set; }

    public short? ReN { get; set; }

    public decimal? ReTpag { get; set; }

    public string? ReEncr { get; set; }

    public string? ReLugR { get; set; }

    public string? ReObs { get; set; }

    public string? ReEstcli { get; set; }
}
