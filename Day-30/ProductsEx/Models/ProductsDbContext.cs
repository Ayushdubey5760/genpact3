using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProductsEx.Models;

public partial class ProductsDbContext : DbContext
{
    public ProductsDbContext()
    {
    }

    public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CompanyInfo> CompanyInfos { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;database=ProductsDb;trusted_connection=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CompanyInfo>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__CompanyI__C1FFD861A185D927");

            entity.ToTable("CompanyInfo");

            entity.Property(e => e.Cid).ValueGeneratedNever();
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .HasColumnName("CName");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__products__C5775520AE3BB5E7");

            entity.ToTable("products");

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("PID");
            entity.Property(e => e.Pcid).HasColumnName("PCid");
            entity.Property(e => e.Pmdate)
                .HasColumnType("datetime")
                .HasColumnName("PMDate");
            entity.Property(e => e.Pname)
                .HasMaxLength(10)
                .HasColumnName("PName");
            entity.Property(e => e.Pprice)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("PPrice");

            entity.HasOne(d => d.Pc).WithMany(p => p.Products)
                .HasForeignKey(d => d.Pcid)
                .HasConstraintName("FK__products__PCid__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
