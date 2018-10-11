using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Core.Entities;

namespace WebShop.Core.DomainServices
{
    public interface IProductRepository
    {
        //Create Data
        Product Create(Product product);

        //Read Data
        Product ReadById(int id);
        IEnumerable<Product> ReadAllProducts();
        IEnumerable<Product> ReadAll(Filter filter = null);

        //Update Data
        Product Update(Product productUpdate);

        //Delete Data
        Product Delete(int id);
    }
}
