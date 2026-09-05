using System;
using System.Collections.Generic;

namespace pepeapi.Model;

public partial class User
{
    public int Iduser { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Patronomic { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Role { get; set; } = null!;
}
