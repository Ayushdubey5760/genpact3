using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class BookDbContext : DbContext
{
    public BookDbContext()
    {
    }

    public BookDbContext(DbContextOptions<BookDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;database=BookDb;trusted_connection=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Aid).HasName("PK__Author__C6900628A8A400E8");

            entity.ToTable("Author");

            entity.HasIndex(e => e.Author1, "UQ__Author__12C0B644A8442CD7").IsUnique();

            entity.Property(e => e.Aid)
                .ValueGeneratedNever()
                .HasColumnName("AId");
            entity.Property(e => e.Author1)
                .HasMaxLength(50)
                .HasColumnName("Author");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Bid).HasName("PK__Book__C6DE0CC1EAC5596E");

            entity.ToTable("Book");

            entity.Property(e => e.Bid)
                .ValueGeneratedNever()
                .HasColumnName("BId");
            entity.Property(e => e.BookName).HasMaxLength(50);

            entity.HasOne(d => d.AuthorNavigation).WithMany(p => p.Books)
                .HasForeignKey(d => d.Author)
                .HasConstraintName("FK__Book__Author__403A8C7D");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Books)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("FK__Book__Category__4222D4EF");

            entity.HasOne(d => d.PublisherNavigation).WithMany(p => p.Books)
                .HasForeignKey(d => d.Publisher)
                .HasConstraintName("FK__Book__Publisher__412EB0B6");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__Category__C1F8DC396F6DB590");

            entity.ToTable("Category");

            entity.HasIndex(e => e.Category1, "UQ__Category__4BB73C322A249BC4").IsUnique();

            entity.Property(e => e.Cid)
                .ValueGeneratedNever()
                .HasColumnName("CId");
            entity.Property(e => e.Category1)
                .HasMaxLength(50)
                .HasColumnName("Category");
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__Publishe__C5775540F4D8FC11");

            entity.ToTable("Publisher");

            entity.HasIndex(e => e.Publisher1, "UQ__Publishe__C25E15ABCAB1A849").IsUnique();

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("PId");
            entity.Property(e => e.Publisher1)
                .HasMaxLength(50)
                .HasColumnName("Publisher");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
