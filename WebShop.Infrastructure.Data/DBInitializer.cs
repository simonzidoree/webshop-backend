using WebShop.Core.Entities;

namespace WebShop.Infrastructure.Data
{
    public class DBInitializer
    {
        public static void SeedDB(WebShopContext ctx)
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
            var category1 = ctx.Categories.Add(new Category
            {
                Name = "Svensk Øl"
            }).Entity;

            var category2 = ctx.Categories.Add(new Category
            {
                Name = "Dansk Øl"
            }).Entity;

            ctx.Products.Add(new Product
            {
                Name = "Tuborg",
                Price = 749.99,
                Description = "Super øl",
                Stock = 10,
                ImageURL = "Intet billede",
                Category = category2
            });

            ctx.Products.Add(new Product
            {
                Name = "Den svenske øl",
                Price = 2500.00,
                Description = "Super øl",
                Stock = 10,
                ImageURL = "Intet billede",
                Category = category1
            });

            ctx.Products.Add(new Product
            {
                Name = "Carlsberg",
                Price = 1249.99,
                Description = "Super øl",
                Stock = 10,
                ImageURL = "Intet billede",
                Category = category2
            });
            ctx.SaveChanges();
        }
    }
}