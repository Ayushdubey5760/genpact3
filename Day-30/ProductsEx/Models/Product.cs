using System;
using System.Collections.Generic;

namespace ProductsEx.Models;

public partial class Product
{
    public int Pid { get; set; }

    public string Pname { get; set; } = null!;

    public decimal? Pprice { get; set; }

    public DateTime? Pmdate { get; set; }

    public int? Pcid { get; set; }

    public virtual CompanyInfo? Pc { get; set; }
}
