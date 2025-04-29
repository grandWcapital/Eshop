using EShop.Domain.Models;

namespace EShop.Application.Dtos
{
    public class ProductDto
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public int numberInStock { get; set; } = 0;
        public IEnumerable<ProductCategory> ProductCategories { get; set; }



    }
}
