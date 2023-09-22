using System;
using System.Collections.Generic;

namespace TheBank.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;

    public double Balance { get; set; }
}
