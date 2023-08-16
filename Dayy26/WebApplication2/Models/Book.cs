using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class Book
{
    public int Bid { get; set; }

    public string BookName { get; set; } = null!;

    public double? BookPrice { get; set; }

    public int? Author { get; set; }

    public int? Publisher { get; set; }

    public int? Category { get; set; }

    public virtual Author? AuthorNavigation { get; set; }

    public virtual Category? CategoryNavigation { get; set; }

    public virtual Publisher? PublisherNavigation { get; set; }
}
