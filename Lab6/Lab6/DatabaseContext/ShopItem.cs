﻿using System;
using System.Collections.Generic;

namespace Lab6.DatabaseContext;

public partial class ShopItem
{
    public ShopItem(int shopID, int itemID)
    {
        ShopId = shopID;
        ItemId = itemID;
    }
    public int ShopId { get; set; }

    public int ItemId { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual Shop Shop { get; set; } = null!;
}
