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
    }
}