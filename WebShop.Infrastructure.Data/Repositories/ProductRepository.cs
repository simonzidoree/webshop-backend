using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WebShop.Core.DomainServices;
using WebShop.Core.Entities;

namespace WebShop.Infrastructure.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly WebShopContext _ctx;

        public ProductRepository(WebShopContext ctx)
        {
            _ctx = ctx;
        }
        
        public Product Create(Product product)
        {
            var prod = _ctx.Products.Add(product).Entity;
            _ctx.SaveChanges();
            return prod;
        }

        public Product Delete(int id)
        {
            var prodRemoved = _ctx.Remove(new Product {Id = id}).Entity;
            _ctx.SaveChanges();
            return prodRemoved;
        }

        public Product ReadById(int id)
        {
            return _ctx.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> ReadAllProducts()
        {
            return _ctx.Products;
        }

        public Product Update(Product productUpdate)
        {
            _ctx.Attach(productUpdate).State = EntityState.Modified;
            _ctx.SaveChanges();
            return productUpdate;
        }
    }
}
