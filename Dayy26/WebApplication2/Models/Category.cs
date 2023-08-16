using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class Category
{
    public int Cid { get; set; }

    public string Category1 { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
