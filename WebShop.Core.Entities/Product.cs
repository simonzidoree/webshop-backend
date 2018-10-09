using System;

namespace WebShop.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string ImageURL { get; set; }
        public Category Category { get; set; }
    }
}
