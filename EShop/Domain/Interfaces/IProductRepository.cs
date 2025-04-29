using EShop.Domain.Models;
using System.Threading.Tasks;

namespace EShop.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<int> AddProductAsync(Product product);
    }
}
