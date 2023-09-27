using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class PrEmpleado
{
    public int EmSerial { get; set; }

    public int EmReloj { get; set; }

    public string EmCi { get; set; } = null!;

    public string EmPaterno { get; set; } = null!;

    public string EmMaterno { get; set; } = null!;

    public string EmNoms { get; set; } = null!;

    public string EmSexo { get; set; } = null!;

    public bool EmJefe { get; set; }

    public int EmSede { get; set; }

    public string EmOcupacion { get; set; } = null!;

    public decimal EmSueldo { get; set; }

    public DateTime EmFing { get; set; }

    public DateTime? EmFretiro { get; set; }

    public string EmMotivo { get; set; } = null!;

    public byte[]? EmFoto { get; set; }

    public string EmDomicilio { get; set; } = null!;

    public string EmTelf { get; set; } = null!;

    public string EmTipotelf { get; set; } = null!;

    public DateTime EmFnac { get; set; }

    public string EmLugnac { get; set; } = null!;

    public string EmProvnac { get; set; } = null!;

    public string EmNacionalidad { get; set; } = null!;

    public string EmNompadre { get; set; } = null!;

    public string EmNommadre { get; set; } = null!;

    public string EmEcivil { get; set; } = null!;

    public string EmProfesion { get; set; } = null!;

    public string EmInstruccion { get; set; } = null!;

    public string EmCarnetMed { get; set; } = null!;

    public string EmDocs { get; set; } = null!;

    public string EmSeñales { get; set; } = null!;

    public string EmObserv { get; set; } = null!;

    public string EmEmptipo { get; set; } = null!;

    public int EmTurno1 { get; set; }

    public int? EmTurno2 { get; set; }

    public short EmOrden { get; set; }

    public bool? EmMarca { get; set; }

    public string EmEstado { get; set; } = null!;

    public bool EmAporta { get; set; }

    public string EmNua { get; set; } = null!;

    public bool EmAfp { get; set; }

    public decimal EmSaldomesant { get; set; }
}
