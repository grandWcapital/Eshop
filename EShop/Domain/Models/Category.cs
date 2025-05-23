﻿namespace EShop.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
      
        public IEnumerable<ProductCategory> ProductCategories { get; set; }

    }
}