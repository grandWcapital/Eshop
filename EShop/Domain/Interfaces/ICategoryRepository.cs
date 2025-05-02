using EShop.Domain.Models;

namespace EShop.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
    }
}
