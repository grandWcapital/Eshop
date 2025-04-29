using EShop.Domain.Models;

namespace EShop.Domain.Interfaces
{
    public interface IProductCategoryRepository
    {
        Task<int> AddProductCategory(ProductCategory category);
    }
}
