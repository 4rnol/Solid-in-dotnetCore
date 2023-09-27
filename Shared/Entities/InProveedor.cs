using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InProveedor
{
    public int PrId { get; set; }

    public int PrIdsub { get; set; }

    public string PrNombre { get; set; } = null!;

    public string PrDireccion { get; set; } = null!;

    public string PrCodigo { get; set; } = null!;

    public string PrUbicacion { get; set; } = null!;

    public string PrGrupo { get; set; } = null!;

    public string PrTelefono { get; set; } = null!;

    public string PrVendedor { get; set; } = null!;

    public string PrNitfa { get; set; } = null!;

    public bool PrClub { get; set; }

    public string PrCelular { get; set; } = null!;

    public string PrNombrefa { get; set; } = null!;

    public string PrSuc { get; set; } = null!;
}
