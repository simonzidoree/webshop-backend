using System;
using System.IO;
using Moq;
using WebShop.Core.ApplicationServices;
using WebShop.Core.ApplicationServices.Services;
using WebShop.Core.DomainServices;
using WebShop.Core.Entities;
using Xunit;

namespace WebShop.xUnitTest.Core.ApplicationServices.Services
{
    public class ProductServiceTest
    {
        public ProductServiceTest()
        {
            //Add reusable stuff here.
        }

        [Fact]
        public void Dispose()
        {
            //For disposing stuff we don't need anymore.
        }

        [Fact]
        public void CreateProductShouldCallProductRepoCreateProductOnce()
        {
            var productRepo = new Mock<IProductRepository>();
            IProductService service =
                new ProductService(productRepo.Object);

            var product = new Product()
            {
                Category = new Category(){Id = 1}
            };
            service.CreateProduct(product);
            productRepo.Verify(x => x.Create(It.IsAny<Product>()), Times.Once);
        }

        [Fact]
        public void CreateProductWithCategoryMissingThrowsException()
        {
            var productRepo = new Mock<IProductRepository>();
            IProductService service =
                new ProductService(productRepo.Object);

            var product = new Product();

            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateProduct(product));
            Assert.Equal("To create a Product, you need a Category", ex.Message);
        }
    }
}