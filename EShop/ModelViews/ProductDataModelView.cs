using EShop.Domain.Models;

namespace EShop.ModelViews
{
    public class ProductDataModelView
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public int numberInStock { get; set; } 
       

    }
}
