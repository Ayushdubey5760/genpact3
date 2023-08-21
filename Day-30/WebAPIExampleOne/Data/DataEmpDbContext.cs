using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIExampleOne.EMp;

namespace WebAPIExampleOne
{
    public class DataEmpDbContext : DbContext
    {
        public DataEmpDbContext (DbContextOptions<DataEmpDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIExampleOne.EMp.Emp> Emp { get; set; } = default!;
    }
}
