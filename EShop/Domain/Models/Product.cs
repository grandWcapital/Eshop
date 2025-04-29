using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace EShop.Domain.Models
{
    public class Product 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; } 

        public int numberInStock { get; set; } = 0;
        public IEnumerable<ProductCategory> ProductCategories { get; set; } 




    }
}
