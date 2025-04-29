using EShop.Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EShop.ModelViews
{
    public class CategorySelectModelView
    {
        
        public List<int> CategoryIds { get; set; } = new List<int>();
        public List<SelectListItem> CategoryNames { get; set; } = new();
    }
}
