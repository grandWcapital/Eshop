using EShop.Domain.Interfaces;
using EShop.Domain.Models;
using EShop.Interface.Data;

namespace EShop.Infrastructure.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly EShopDbContext _context;

        public ProductCategoryRepository(EShopDbContext context)
        {
            _context = context;
        }
        
        public async Task<int> AddProductCategory(ProductCategory category)
        {
            _context.Add(category);
            return await _context.SaveChangesAsync();
        }
    }
}
