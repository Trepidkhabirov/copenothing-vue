using System;
using System.Collections.Generic;

namespace pepeapi.Model;

public partial class Basket
{
    public int UserId { get; set; }

    public int ProductId { get; set; }

    public int Count { get; set; }

    public string Title { get; set; } = null!;

    public string Image { get; set; } = null!;

    public int Cost { get; set; }
}
