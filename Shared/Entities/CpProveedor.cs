using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CpProveedor
{
    public int PrId { get; set; }

    public int? PrGrupo { get; set; }

    public int? PrCodigo { get; set; }

    public string? PrNombre { get; set; }

    public string? PrDireccion { get; set; }

    public string? PrUbicacion { get; set; }

    public string? PrTelefono { get; set; }

    public string? PrFax { get; set; }

    public string? PrContacto { get; set; }

    public string? PrRuc { get; set; }

    public string? PrRegistro { get; set; }

    public string? PrCelular { get; set; }

    public string? PrContactoc { get; set; }

    public string? PrEmail { get; set; }

    public int? PrTipocredito { get; set; }
}
