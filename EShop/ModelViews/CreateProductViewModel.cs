using Microsoft.AspNetCore.Mvc.Rendering;

namespace EShop.ModelViews
{
    public class CreateProductViewModel
    {
        
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public string Image { get; set; }
            public int NumberInStock { get; set; }

            // Selected categories from form
            public List<int> CategoryIds { get; set; }

            // Optional: used to populate the dropdown
            public List<SelectListItem> AllCategories { get; set; }
        


    }
}
