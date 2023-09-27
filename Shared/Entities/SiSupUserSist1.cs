using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class SiSupUserSist1
{
    public int SuUser { get; set; }

    public string SuSist { get; set; } = null!;

    public bool? SuCheck { get; set; }

    public short SuSession { get; set; }
}
