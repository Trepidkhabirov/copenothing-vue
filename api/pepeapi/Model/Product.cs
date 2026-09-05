using System;
using System.Collections.Generic;

namespace pepeapi.Model;

public partial class Product
{
    public int Idproduct { get; set; }

    public string Title { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Cost { get; set; }

    public int Count { get; set; }

    public int CategoryId { get; set; }

    public string Status { get; set; } = null!;
}
