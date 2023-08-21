using System;
using System.Collections.Generic;

namespace ProductsEx.Models;

public partial class CompanyInfo
{
    public int Cid { get; set; }

    public string Cname { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
