using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProductsMvcDbFirst.Models
{
    public partial class ProductsMvcDbFirstContext : DbContext
    {
        public ProductsMvcDbFirstContext()
        {
        }

        public ProductsMvcDbFirstContext(DbContextOptions<ProductsMvcDbFirstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=TROYSPC;Initial Catalog=ProductsMvcDbFirst; Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Brand).HasMaxLength(100);

                entity.Property(e => e.CurrentStock).HasColumnName("Current stock");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("Last updated");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.WholesaleCost)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("Wholesale cost");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
