using System.Collections.Generic;
using System.IO;
using System.Linq;
using WebShop.Core.DomainServices;
using WebShop.Core.Entities;

namespace WebShop.Core.ApplicationServices.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product NewProduct(string name, double price, string description, int stock, string imageURL)
        {
            var product = new Product
            {
                Name = name,
                Price = price,
                Description = description,
                Stock = stock,
                ImageURL = imageURL
            };

            return product;
        }

        public Product CreateProduct(Product product)
        {
            if (string.IsNullOrEmpty(product.Name))
            {
                throw new InvalidDataException("To create a Product, the Product needs a name");
            }

            return _productRepository.Create(product);
        }

        public Product FindProductById(int id)
        {
            return _productRepository.ReadById(id);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.ReadAllProducts().ToList();
        }

        public Product UpdateProduct(Product productUpdate)
        {
            var product = FindProductById(productUpdate.Id);
            product.Name = productUpdate.Name;
            product.Price = productUpdate.Price;
            product.Description = productUpdate.Description;
            product.Stock = productUpdate.Stock;
            product.ImageURL = productUpdate.ImageURL;
            return _productRepository.Update(product);
        }

        public Product DeleteProduct(int id)
        {
            return _productRepository.Delete(id);
        }
    }
}