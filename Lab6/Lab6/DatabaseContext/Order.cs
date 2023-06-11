using System;
using System.Collections.Generic;

namespace Lab6.DatabaseContext;

public partial class Order
{
    public int OrderId { get; set; }

    public int ShopId { get; set; }

    public int ItemId { get; set; }

    public int OrderCid { get; set; }

    public DateTime OrderDate { get; set; }

    public virtual Delivery? Delivery { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual Shop Shop { get; set; } = null!;
}
