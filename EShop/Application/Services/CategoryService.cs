using EShop.Domain.Models;
using EShop.Interface.Data;
using EShop.ModelViews;
using Microsoft.EntityFrameworkCore;

namespace EShop.Application.Services
{
    public class CategoryService
    {
        private readonly EShopDbContext _context;
        public CategoryService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            var categories = from c in _context.Categories
                             from pc in _context.ProductCategories.Where(pc => pc.CategoryId == c.Id)
                             from p in _context.Products.Where(p => p.Id == pc.ProductId)
                             select new Category()
                             {
                                 Id = c.Id,
                                 Name = c.Name,
                                 Description = c.Description,
                                 
                             };
            return await categories.ToListAsync();
        }
        
    }
}
