using System;
using System.Collections.Generic;

namespace Epsa.Shared.Entities;

public partial class CrCobranza
{
    public int CoSeller { get; set; }

    public DateTime? CoDate { get; set; }

    public string CoNdoc { get; set; } = null!;

    public string CoCustomer { get; set; } = null!;

    public decimal CoTsale { get; set; }

    public decimal CoTpayment { get; set; }

    public short CoStep { get; set; }

    public int CoOpid { get; set; }
}
