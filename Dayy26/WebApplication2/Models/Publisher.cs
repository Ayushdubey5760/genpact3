using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class Publisher
{
    public int Pid { get; set; }

    public string Publisher1 { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
