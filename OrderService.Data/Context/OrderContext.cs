using OrderOfService.Data.Entities;
using System.Data.Entity;

namespace OrderOfService.Data.Context
{
    public class OrderContext: DbContext
    {

        public OrderContext()
        {
                
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderItem)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.Product)
                .IsUnicode(false);
        }
    }
}
