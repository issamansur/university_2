using System;
using System.Collections.Generic;

namespace Lab6.DatabaseContext;

public partial class Delivery
{
    public int OrderId { get; set; }

    public string DelAddress { get; set; } = null!;

    public string DelCourier { get; set; } = null!;

    public decimal DelCost { get; set; }

    public DateTime DelDate { get; set; }

    public virtual Order Order { get; set; } = null!;
}
