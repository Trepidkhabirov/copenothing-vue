using System;
using System.Collections.Generic;

namespace pepeapi.Model;

public partial class OrderItem
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Count { get; set; }
}
