using System.Collections.Generic;

namespace WebShop.Core.Entities
{
    public class Category
    {
        public int CatId { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}