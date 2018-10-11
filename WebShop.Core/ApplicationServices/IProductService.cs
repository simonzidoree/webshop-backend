using System.Collections.Generic;
using WebShop.Core.Entities;

namespace WebShop.Core.ApplicationServices
{
    public interface IProductService
    {
        //New Product
        Product NewProduct(string name,
            double price,
            string description,
            int stock,
            string imageURL);

        //Create
        Product CreateProduct(Product product);

        //Read
        Product FindProductById(int id);

        List<Product> GetAllProducts();

        //Update
        Product UpdateProduct(Product productUpdate);

        //Delete
        Product DeleteProduct(int id);
    }
}