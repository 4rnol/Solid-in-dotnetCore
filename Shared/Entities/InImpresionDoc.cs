using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InImpresionDoc
{
    public string IdCodigo { get; set; } = null!;

    public int IdContrato { get; set; }

    public string IdDetalle { get; set; } = null!;

    public string IdDoc { get; set; } = null!;

    public string IdBco { get; set; } = null!;

    public decimal IdImporteD { get; set; }

    public decimal IdImporteH { get; set; }

    public int IdSerial { get; set; }

    public string IdNombre { get; set; } = null!;

    public int IdIdent { get; set; }
}
