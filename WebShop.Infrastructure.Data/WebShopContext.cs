using Microsoft.EntityFrameworkCore;
using WebShop.Core.Entities;

namespace WebShop.Infrastructure.Data
{
    public class WebShopContext : DbContext
    {
        public WebShopContext(DbContextOptions<WebShopContext> opt) : base(opt)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(p => p.Products)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}