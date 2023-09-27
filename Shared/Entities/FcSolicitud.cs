using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcSolicitud
{
    public int SoNro { get; set; }

    public string? SoTipo { get; set; }

    public string? SoPaterno { get; set; }

    public string? SoMaterno { get; set; }

    public string? SoNombre { get; set; }

    public string? SoTelefono { get; set; }

    public string? SoCirun { get; set; }

    public string? SoDirec { get; set; }

    public string? SoDirentre { get; set; }

    public string? SoDiry { get; set; }

    public string? SoDirnro { get; set; }

    public string? SoPropDo { get; set; }

    public string? SoLocalidad { get; set; }

    public bool? SoMed { get; set; }

    public string? SoZona { get; set; }

    public string SoCateg { get; set; } = null!;

    public DateTime? SoFechai { get; set; }

    public DateTime? SoFechaf { get; set; }

    public int? SoTiempo { get; set; }

    public string? SoEstado { get; set; }

    public string? SoModred { get; set; }

    public string? SoObser { get; set; }

    public string? SoCtacli { get; set; }

    public int? SoOper { get; set; }

    public string? SoCheck { get; set; }

    public string? SoSistema { get; set; }

    public string? SoCtto { get; set; }
}
