using System;
using System.Collections.Generic;

namespace Payment.Models;

public partial class Record
{
    public int PaymentId { get; set; }

    public string Concept { get; set; } = null!;

    public int Amount { get; set; }
}
