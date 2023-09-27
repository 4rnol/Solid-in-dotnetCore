using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class InPromotor
{
    public string ClCuenta { get; set; } = null!;

    public string ClNombre { get; set; } = null!;

    public string ClDirec { get; set; } = null!;

    public string ClTelf { get; set; } = null!;

    public string ClRuc { get; set; } = null!;

    public string ClObs { get; set; } = null!;

    public string ClEmail { get; set; } = null!;

    public string ClTipo { get; set; } = null!;

    public string ClUbicacion { get; set; } = null!;

    public string ClContacto { get; set; } = null!;

    public string ClGrupo { get; set; } = null!;

    public DateTime? ClFechan { get; set; }

    public DateTime? ClFechai { get; set; }

    public bool ClActivo { get; set; }
}
