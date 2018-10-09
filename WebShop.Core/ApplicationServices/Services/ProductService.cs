using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Core.Entities;

namespace WebShop.Core.ApplicationServices.Services
{
    class ProductService : IProductService
    {
        public Product CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product FindProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product NewProduct(string name, double price, string description, int stock, string imageURL)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(int id, Product productUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
