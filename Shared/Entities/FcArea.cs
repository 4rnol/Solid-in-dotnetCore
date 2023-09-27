using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class FcArea
{
    public short AaId { get; set; }

    public string? AaCodare { get; set; }

    public string? AaDesc { get; set; }

    public string? AaSucIi { get; set; }

    public string? AaFileIi { get; set; }

    public long? AaSeqPrea { get; set; }

    public long? AaSeqCort { get; set; }

    public bool? AaEst { get; set; }

    public string? AaDir { get; set; }

    public string? AaTel { get; set; }
}
