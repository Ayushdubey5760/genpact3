using Da28Ex.Models;
using Microsoft.EntityFrameworkCore;

namespace Da28Ex.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Players>
    }
    }
}
