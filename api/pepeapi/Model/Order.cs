using System;
using System.Collections.Generic;

namespace pepeapi.Model;

public partial class Order
{
    public int Idorder { get; set; }

    public int PriceAll { get; set; }

    public DateOnly DateOrder { get; set; }

    public int UserId { get; set; }

    public string Status { get; set; } = null!;

    public string AdressDelivery { get; set; } = null!;

    public DateOnly DateDelivery { get; set; }
}
