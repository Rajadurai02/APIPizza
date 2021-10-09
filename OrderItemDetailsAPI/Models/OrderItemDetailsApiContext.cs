using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace OrderItemDetailsAPI.Models
{
    public partial class OrderItemDetailsApiContext : DbContext
    {
        public OrderItemDetailsApiContext()
        {
        }

        public OrderItemDetailsApiContext(DbContextOptions<OrderItemDetailsApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderItemDetail> OrderItemDetails { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__OrderDet__727E83EB3625791D");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PizzaId).HasColumnName("PizzaID");
            });

            modelBuilder.Entity<OrderItemDetail>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.ToppingId })
                    .HasName("PK__OrderIte__3C9EAF25747EC656");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ToppingId).HasColumnName("ToppingID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.OrderItemDetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderItem__ItemI__38996AB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
