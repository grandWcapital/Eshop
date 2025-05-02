using EShop.Domain.Models;
using EShop.ModelViews;

namespace EShop.Application.Services
{
    public interface IProductService
    {
        Task<int> AddProductAsync(CreateProductViewModel createProductViewModel);
        
    }
}
