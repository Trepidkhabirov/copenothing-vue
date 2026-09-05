using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace pepeapi.Model;

public partial class FrogbdContext : DbContext
{
    public FrogbdContext()
    {
    }

    public FrogbdContext(DbContextOptions<FrogbdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Basket> Baskets { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user=root;password=1234;database=frogbd", Microsoft.EntityFrameworkCore.ServerVersion.Parse("12.3.3-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_unicode_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Basket>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.ProductId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("Basket")
                .UseCollation("utf8mb4_uca1400_ai_ci");

            entity.HasIndex(e => new { e.UserId, e.ProductId }, "unique_user_product").IsUnique();

            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("UserID");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("ProductID");
            entity.Property(e => e.Cost).HasColumnType("int(11)");
            entity.Property(e => e.Count).HasColumnType("int(11)");
            entity.Property(e => e.Image).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Idcategory).HasName("PRIMARY");

            entity.UseCollation("utf8mb4_uca1400_ai_ci");

            entity.Property(e => e.Idcategory)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("IDCategory");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Idorder).HasName("PRIMARY");

            entity.UseCollation("utf8mb4_uca1400_ai_ci");

            entity.Property(e => e.Idorder)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("IDOrder");
            entity.Property(e => e.AdressDelivery).HasMaxLength(100);
            entity.Property(e => e.DateOrder).HasColumnName("dateOrder");
            entity.Property(e => e.PriceAll).HasColumnType("int(11)");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ProductId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.UseCollation("utf8mb4_uca1400_ai_ci");

            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("OrderID");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("ProductID");
            entity.Property(e => e.Count).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => new { e.Idproduct, e.CategoryId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.UseCollation("utf8mb4_uca1400_ai_ci");

            entity.Property(e => e.Idproduct)
                .HasColumnType("int(11)")
                .HasColumnName("IDProduct");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("CategoryID");
            entity.Property(e => e.Cost).HasColumnType("int(11)");
            entity.Property(e => e.Count).HasColumnType("int(11)");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Image).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Iduser).HasName("PRIMARY");

            entity.UseCollation("utf8mb4_uca1400_ai_ci");

            entity.Property(e => e.Iduser)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("IDUser");
            entity.Property(e => e.Login).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Patronomic).HasMaxLength(100);
            entity.Property(e => e.Role).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.Surname).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
